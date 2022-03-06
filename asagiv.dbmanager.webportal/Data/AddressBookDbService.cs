﻿using asagiv.dbmanager.common.Models;
using asagiv.dbmanager.common.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace asagiv.dbmanager.webportal.Data
{
    public class AddressBookDbService
    {
        #region Fields
        private FamilyCollection _families;
        private AddressCollection _addresses;
        private PeopleCollection _people;
        private EventsCollection _events;
        private FamilyEventGiftCollection _familyEventGifts;
        private EventGiftCollection _eventGifts;
        #endregion

        #region Constructor
        public AddressBookDbService(FamilyCollection families,
            AddressCollection addresses,
            PeopleCollection people, 
            EventsCollection events,
            FamilyEventGiftCollection familyEventGifts,
            EventGiftCollection eventGift)
        {
            _families = families;
            _addresses = addresses;
            _people = people;
            _events = events;
            _familyEventGifts = familyEventGifts;
            _eventGifts = eventGift;
        }
        #endregion

        #region Methods
        public async IAsyncEnumerable<Family> GetAllFamiliesAsync(string? searchString = null)
        {
            IAsyncEnumerable<Family?> familyEnumearble = _families.GetEnumerable()
                .OrderBy(x => x?.FamilyName);

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                familyEnumearble = familyEnumearble
                    .Where(x => x.AddressHeader.ToLower().Contains(searchString.ToLower()));
            }

            var addresses = await _addresses.ReadManyAsync();

            if (addresses == null)
            {
                yield break;
            }

            await foreach (var family in familyEnumearble)
            {
                if (family == null)
                {
                    continue;
                }

                family.Addresses = addresses
                    .Where(x => x?.FamilyId == family.Id)
                    .ToList();

                yield return family;
            }
        }

        public async Task<Family?> GetFamilyAsync(ObjectId id)
        {
            var family = await _families.ReadAsync(id);

            if (family == null)
            {
                return null;
            }

            var addresses = await _addresses
                .AsQueryable()
                .Where(x => x.FamilyId == id)
                .ToListAsync();

            family.Addresses = addresses;

            var people = await _people
                .AsQueryable()
                .Where(x => x.FamilyId == id)
                .ToListAsync();

            family.People = people;

            return family;
        }

        public async Task DeleteFamilyAsync(ObjectId id)
        {
            // Cascade delete people
            var peopleToDelete = await _people
                .AsQueryable()
                .Where(x => x.FamilyId == id)
                .Select(x => x.Id)
                .ToListAsync();

            await _people.DeleteManyAsync(peopleToDelete.ToArray());

            // Cascade delete addresses
            var addressesToDelete = await _addresses
                .AsQueryable()
                .Where(x => x.FamilyId == id)
                .Select(x => x.Id)
                .ToListAsync();

            await _addresses.DeleteManyAsync(addressesToDelete.ToArray());

            await _families.DeleteAsync(id);
        }

        public async Task SaveFamilyAsync(Family family, IList<Address>? removedAddresses, IList<Person>? removedPeople)
        {
            await _families.AppendAsync(family);

            // Delete removed addresses and people.
            if (removedAddresses != null)
            {
                await _addresses.DeleteManyAsync(removedAddresses.Select(x => x.Id).ToArray());
            }

            if (removedPeople != null)
            {
                await _people.DeleteManyAsync(removedPeople.Select(x => x.Id).ToArray());
            }

            // Add new addresses and people.
            foreach (var address in family.Addresses)
            {
                await _addresses.AppendAsync(address);
            }

            foreach (var person in family.People)
            {
                await _people.AppendAsync(person);
            }
        }

        public Task<List<EventInfo>> GetAllEventsAsync()
        {
            return _events
                .AsQueryable()
                .OrderBy(x => x.EventName)
                .ToListAsync();
        }

        public async Task<List<FamilyEventGift>> GetFamilyEventGiftsAsync(EventInfo eventInfo)
        {
            var familyEventGifts = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.EventId == eventInfo.Id)
                .ToListAsync();

            var giftIds = familyEventGifts.Select(x => x.GiftId).ToList();
            var familyIds = familyEventGifts.Select(x => x.FamilyId).ToList();

            var gifts = await _eventGifts
                .AsQueryable()
                .Where(x => giftIds.Contains(x.Id))
                .ToListAsync();

            var families = await _families
                .AsQueryable()
                .Where(x => familyIds.Contains(x.Id))
                .ToListAsync();

            foreach(var familyEventGift in familyEventGifts)
            {
                familyEventGift.EventInfo = eventInfo;
                familyEventGift.Family = families.FirstOrDefault(x => x.Id == familyEventGift.FamilyId);
                familyEventGift.EventGift = gifts.FirstOrDefault(x => x.Id == familyEventGift.GiftId);
            }

            return familyEventGifts;
        }

        public async Task UpdateThankYouNoteWrittenAsync(FamilyEventGift familyEventGift)
        {
            await _familyEventGifts.AppendAsync(familyEventGift);
        }

        public Task<EventGift?> GetGiftAsync(ObjectId id)
        {
            return _eventGifts.ReadAsync(id);
        }

        public Task<List<FamilyEventGift>> GetFamilyEventGiftsAsync(ObjectId eventGiftId)
        {
            return _familyEventGifts
                .AsQueryable()
                .Where(x => x.GiftId == eventGiftId)
                .ToListAsync();
        }
        #endregion
    }
}
