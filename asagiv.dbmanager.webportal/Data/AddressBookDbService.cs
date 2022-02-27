using System.Linq;
using asagiv.dbmanager.common.Models;
using asagiv.dbmanager.common.MongoDB;

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
        #endregion
    }
}
