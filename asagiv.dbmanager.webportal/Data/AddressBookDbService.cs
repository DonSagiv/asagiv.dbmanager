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
        private readonly ILogger? _logger;
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
            EventGiftCollection eventGift,
            ILogger? logger = null)
        {
            _logger = logger;

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
                _logger?.LogInformation("Searchstring set to {Searchstring}", searchString);

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

            _logger?.LogInformation("Getting Family Info for Family.");

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

            _logger?.LogInformation("Deleting {PeopleToDelete} People.", peopleToDelete.Count);

            await _people.DeleteManyAsync(peopleToDelete.ToArray());

            // Cascade delete addresses
            var addressesToDelete = await _addresses
                .AsQueryable()
                .Where(x => x.FamilyId == id)
                .Select(x => x.Id)
                .ToListAsync();

            _logger?.LogInformation("Deleting {AddressesToDelete} Addresses.", addressesToDelete.Count);

            await _addresses.DeleteManyAsync(addressesToDelete.ToArray());

            _logger?.LogInformation("Deleting Family.");

            await _families.DeleteAsync(id);
        }

        public async Task SaveFamilyAsync(Family family, IList<Address>? removedAddresses, IList<Person>? removedPeople)
        {
            _logger?.LogInformation("Saving Family.");
            
            await _families.AppendAsync(family);

            // Delete removed addresses and people.
            if (removedAddresses != null)
            {
                _logger?.LogInformation("Deleting {AddressesToRemove} Addresses.", removedAddresses.Count);

                await _addresses.DeleteManyAsync(removedAddresses.Select(x => x.Id).ToArray());
            }

            if (removedPeople != null)
            {
                _logger?.LogInformation("Deleting {PeopleToRemove} Addresses.", removedPeople.Count);

                await _people.DeleteManyAsync(removedPeople.Select(x => x.Id).ToArray());
            }

            // Add new addresses and people.
            _logger?.LogInformation("Appending {AddressesToSave} Addresses.", family.Addresses.Count);

            foreach (var address in family.Addresses)
            {
                await _addresses.AppendAsync(address);
            }

            _logger?.LogInformation("Appending {PeopleToSave} People.", family.People.Count);

            foreach (var person in family.People)
            {
                await _people.AppendAsync(person);
            }
        }

        public Task<List<EventInfo>> GetAllEventsAsync()
        {
            _logger?.LogInformation("Retrieving All Events");

            return _events
                .AsQueryable()
                .OrderBy(x => x.EventName)
                .ToListAsync();
        }

        public async Task<List<FamilyEventGift>> GetGiftsForEvent(ObjectId eventId)
        {
            _logger?.LogInformation("Get Family Event Gifts for Event.");

            var eventInfo = await _events.ReadAsync(eventId);

            if(eventInfo == null)
            {
                return new List<FamilyEventGift>();
            }

            return await GetFamilyEventGiftsAsync(eventInfo);
        }

        public async Task<List<FamilyEventGift>> GetFamilyEventGiftsAsync(EventInfo eventInfo)
        {
            _logger?.LogInformation("Getting All Family Gifts for Event {EventInfo}.", eventInfo.EventName);

            var familyEventGifts = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.EventId == eventInfo.Id)
                .ToListAsync();

            var giftIds = familyEventGifts.ConvertAll(x => x.GiftId);
            var familyIds = familyEventGifts.ConvertAll(x => x.FamilyId);

            _logger?.LogInformation("Getting All Event Gifts.");

            var gifts = await _eventGifts
                .AsQueryable()
                .Where(x => giftIds.Contains(x.Id))
                .ToListAsync();

            _logger?.LogInformation("Getting All Families.");

            var families = await _families
                .AsQueryable()
                .Where(x => familyIds.Contains(x.Id))
                .ToListAsync();

            _logger?.LogInformation("Populating Family Event Gifts.");

            foreach (var familyEventGift in familyEventGifts)
            {
                familyEventGift.EventInfo = eventInfo;
                familyEventGift.Family = families.Find(x => x.Id == familyEventGift.FamilyId);
                familyEventGift.EventGift = gifts.Find(x => x.Id == familyEventGift.GiftId);
            }

            return familyEventGifts;
        }

        public async Task UpdateThankYouNoteWrittenAsync(FamilyEventGift familyEventGift)
        {
            _logger?.LogInformation("Thank You Note Status Updated: {IsTrue}.", familyEventGift.ThankYouNoteWritten);

            await _familyEventGifts.AppendAsync(familyEventGift);
        }

        public Task<EventGift?> GetGiftAsync(ObjectId id)
        {
            _logger?.LogInformation("Retrieving Gift.");

            return _eventGifts.ReadAsync(id);
        }

        public async Task<List<FamilyEventGift>> GetFamilyEventGiftsAsync(ObjectId eventId, ObjectId giftId)
        {
            _logger?.LogInformation("Getting Gift for Event.");

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
            _logger?.LogInformation("Saving Family Event Gift.");

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
            _logger?.LogInformation("Appending Event.");

            await _events.AppendAsync(eventInfo);
        }

        public async Task DeleteGiftAsync(FamilyEventGift familyEventGift)
        {
            _logger?.LogInformation("Deleting Family Event Gift.");

            var allFamilyEventGifts = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.GiftId == familyEventGift.GiftId)
                .Select(x => x.Id)
                .ToListAsync();

            await _familyEventGifts.DeleteManyAsync(allFamilyEventGifts.ToArray());

            await _eventGifts.DeleteAsync(familyEventGift.GiftId);
        }

        public async Task DeleteEventAsync(EventInfo eventInfo)
        {
            _logger?.LogInformation("Deleting Event.");

            var eventFamilyGiftsToDelete = await _familyEventGifts
                .AsQueryable()
                .Where(x => x.EventId == eventInfo.Id)
                .ToListAsync();

            var eventFamilyGiftIds = eventFamilyGiftsToDelete
                .Select(x => x.Id)
                .ToArray();

            _logger?.LogInformation("Deleting Family Event Gifts for Event.");

            await _familyEventGifts.DeleteManyAsync(eventFamilyGiftIds);

            var giftIds = eventFamilyGiftsToDelete
                .Select(x => x.GiftId)
                .ToArray();

            _logger?.LogInformation("Deleting Gifts for Event.");

            await _eventGifts.DeleteManyAsync(giftIds);

            await _events.DeleteAsync(eventInfo.Id);
        }
        #endregion
    }
}
