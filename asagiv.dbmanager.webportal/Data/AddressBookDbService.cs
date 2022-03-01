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
        private FamilyCollection _families;
        private AddressCollection _addresses;
        private PeopleCollection _people;
        #endregion

        #region Constructor
        public AddressBookDbService(FamilyCollection families, AddressCollection addresses, PeopleCollection people)
        {
            _families = families;
            _addresses = addresses;
            _people = people;
        }
        #endregion

        #region Methods
        public async IAsyncEnumerable<Family> GetAllFamiliesAsync()
        {
            var familyEnumearble = _families.GetEnumerable()
                .OrderBy(x => x.FamilyName);

            var addresses = await _addresses.ReadManyAsync();

            if(addresses == null)
            {
                yield break;
            }

            await foreach(var family in familyEnumearble)
            {
                if(family == null)
                {
                    continue;
                }

                family.Addresses = addresses
                    .Where(x => x.FamilyId == family.Id)
                    .ToList();

                yield return family;
            }
        }

        public async Task<Family?> GetFamilyAsync(ObjectId id)
        {
            var family = await _families.ReadAsync(id);

            if(family == null)
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

        public async Task SaveFamilyAsync(Family family, IList<Address>? removedAddresses, IList<Person>? removedPeople)
        {
            await _families.AppendAsync(family);

            if(removedAddresses != null)
            {
                await _addresses.DeleteManyAsync(removedAddresses.Select(x => x.Id).ToArray());
            }

            if(removedPeople != null)
            {
                await _people.DeleteManyAsync(removedPeople.Select(x => x.Id).ToArray());
            }

            foreach (var address in family.Addresses)
            {
                await _addresses.AppendAsync(address);
            }

            foreach(var person in family.People)
            {
                await _people.AppendAsync(person);
            }
        }
        #endregion
    }
}
