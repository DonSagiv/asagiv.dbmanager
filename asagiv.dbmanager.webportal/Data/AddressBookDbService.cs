using asagiv.dbmanager.common.Models;
using asagiv.dbmanager.common.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace asagiv.dbmanager.webportal.Data
{
    public class AddressBookDbService
    {
        #region Fields
        private readonly FamilyCollection _families;
        private readonly AddressCollection _addresses;
        private readonly PeopleCollection _people;
        private readonly EventsCollection _events;
        private readonly FamilyEventGiftCollection _familyEventGifts;
        private readonly EventGiftCollection _eventGifts;
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
                    .Where(x => x?.AddressHeader.Contains(searchString, StringComparison.OrdinalIgnoreCase) ?? false);
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

            var giftIds = familyEventGifts.ConvertAll(x => x.GiftId);
            var familyIds = familyEventGifts.ConvertAll(x => x.FamilyId);

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
                familyEventGift.Family = families.Find(x => x.Id == familyEventGift.FamilyId);
                familyEventGift.EventGift = gifts.Find(x => x.Id == familyEventGift.GiftId);
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

        public async Task<List<FamilyEventGift>> GetFamilyEventGiftsAsync(ObjectId eventId)
        {
            var familyEventGifts = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.EventId == eventId)
                .ToListAsync();

            var familyIds = familyEventGifts
                .Select(x => x.FamilyId);

            var families = await _families
                .AsQueryable()
                .Where(x => familyIds.Contains(x.Id))
                .ToListAsync();

            var giftIds = familyEventGifts
                .Select(x => x.GiftId);

            var gifts = await _eventGifts
                .AsQueryable()
                .Where(x => giftIds.Contains(x.Id))
                .ToListAsync();

            foreach(var familyEventGift in familyEventGifts)
            {
                familyEventGift.Family = families
                    .Find(x => x.Id == familyEventGift.FamilyId);

                familyEventGift.EventGift = gifts
                    .Find(x => x.Id == familyEventGift.GiftId);
            }

            return familyEventGifts;
        }

        public async Task<List<FamilyEventGift>> GetFamilyEventGiftsAsync(ObjectId eventId, ObjectId giftId)
        {
            var familyEventGifts = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.EventId == eventId)
                .Where(x => x.GiftId == giftId)
                .ToListAsync();

            var familyIds = familyEventGifts
                .Select(x => x.FamilyId);

            var families = await _families
                .AsQueryable()
                .Where(x => familyIds.Contains(x.Id))
                .ToListAsync();

            foreach (var familyEventGift in familyEventGifts)
            {
                familyEventGift.Family = families
                    .Find(x => x.Id == familyEventGift.FamilyId);
            }

            return familyEventGifts;
        }

        public async Task SaveFamilyEventGiftAsync(EventGift eventGift, IEnumerable<FamilyEventGift> familyEventGifts, IEnumerable<FamilyEventGift> removedFamilyEventGifts)
        {
            await _eventGifts.AppendAsync(eventGift);
        
            await _familyEventGifts.DeleteManyAsync(removedFamilyEventGifts
                .Select(x => x.Id).ToArray());

            foreach(var familyEventGift in familyEventGifts)
            {
                await _familyEventGifts.AppendAsync(familyEventGift);
            }
        }

        public async Task AppendEventAsync(EventInfo eventInfo)
        {
            await _events.AppendAsync(eventInfo);
        }

        public async Task DeleteGiftAsync(FamilyEventGift familyEventGift)
        {
            var allFamilyEventGifts = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.GiftId == familyEventGift.GiftId)
                .Select(x => x.Id)
                .ToListAsync();

            await _familyEventGifts.DeleteManyAsync(allFamilyEventGifts.ToArray());

            await _eventGifts.DeleteAsync(familyEventGift.GiftId);
        }
        #endregion
    }
}
