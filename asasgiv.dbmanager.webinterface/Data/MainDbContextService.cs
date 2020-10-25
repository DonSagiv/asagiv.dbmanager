using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using asagiv.dbmanager.addresses;

namespace asagiv.dbmanager.webinterface.Data
{
    public class MainDbContextService
    {
        #region Properties
        public AddressDbContext dbContext { get; private set; }
        #endregion

        #region Constructor
        public MainDbContextService(IConfiguration configuration)
        {
            var ipAddress = configuration.GetValue<string>("ConnectionSettings:ipAddress");
            var port = configuration.GetValue<string>("ConnectionSettings:port");
            var database = configuration.GetValue<string>("ConnectionSettings:database");
            var userName = configuration.GetValue<string>("ConnectionSettings:username");
            var password = configuration.GetValue<string>("ConnectionSettings:password");

            dbContext = new AddressDbContext(ipAddress, port, database, userName, password);
        }
        #endregion

        #region Methods
        public async Task<IList<Family>> getFamiliesAsync()
        {
            return await dbContext.Families
                .OrderBy(x => x.familyName)
                .ToListAsync();
        }

        public async Task<IList<Family>> filterFamiliesAsync(string filterString)
        {
            var asyncEnumerable = await getFamiliesAsync();

            return asyncEnumerable
                .Where(x => x.ToSearchableString().Contains(filterString.ToLower()))
                .ToList();
        }

        public async Task<IList<string>> getFamilyAddressHeadersAsync()
        {
            return await dbContext.Families
                .OrderBy(x => x.addressHeader)
                .Select(x => x.ToString())
                .ToListAsync();
        }

        public async Task<Family> getFamilyFromIdAsync(long familyId)
        {
            return await dbContext.Families
                .FirstOrDefaultAsync(x => x.familyId == familyId);
        }

        public async Task saveFamilyAsync(Family family)
        {
            if (!dbContext.Families.Contains(family))
                await dbContext.Families.AddAsync(family);

            await dbContext.SaveChangesAsync();
        }

        public async Task deleteFamilyAsync(Family family)
        {
            if (!dbContext.Families.Contains(family)) return;

            dbContext.Families.Remove(family);

            await dbContext.SaveChangesAsync();
        }

        public async Task<IList<FamilyBabyGift>> getBabyGiftListAsync()
        {
            return await dbContext.FamilyBabyGifts
                .OrderBy(x => x.thankYouNoteWritten)
                .ThenBy(x => x.family.familyName)
                .ToListAsync();
        }

        public async Task addGiftAsync(BabyGift babyGift, IList<Family> familyList)
        {
            if (!(await dbContext.BabyGifts.ContainsAsync(babyGift)))
                await dbContext.BabyGifts.AddAsync(babyGift);

            var peopleBabyGifts = await dbContext.FamilyBabyGifts
                .Where(x => x.babyGift == babyGift)
                .Select(x => x.family)
                .ToListAsync();

            var familiesToAdd = familyList.Except(peopleBabyGifts).ToList();
            var familiesToRemove = peopleBabyGifts.Except(familyList).ToList();

            foreach (var person in familiesToAdd)
            {
                var peopleBabyGift = new FamilyBabyGift
                {
                    babyGift = babyGift,
                    family = person,
                };

                var peopleEntityEntry = await dbContext.FamilyBabyGifts.AddAsync(peopleBabyGift);
            }

            foreach (var person in familiesToRemove)
            {
                var removeList = dbContext.FamilyBabyGifts
                    .Where(x => x.family == person)
                    .Where(x => x.babyGift == babyGift)
                    .ToList();

                foreach (var item in removeList)
                    dbContext.FamilyBabyGifts.Remove(item);
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task<long?> getGift(string gift, string name, string city)
        {
            var family = await dbContext
                .Families
                .Where(x => x.addresses.FirstOrDefault().city == city)
                .FirstOrDefaultAsync(x => x.familyName == name);

            var familyGift = await dbContext
                .FamilyBabyGifts
                .FirstOrDefaultAsync(x => x.familyId == family.familyId);

            return await dbContext.BabyGifts
                .Where(x => x.giftDescription == gift)
                .Where(x => x.giftId == familyGift.babyGiftId)
                .Select(x => x.giftId)
                .FirstOrDefaultAsync();
        }

        public async Task<IList<Family>> getPeopleFromGift(BabyGift babyGift)
        {
            return await dbContext.FamilyBabyGifts
                .Where(x => x.babyGiftId == babyGift.giftId)
                .Select(x => x.family)
                .ToListAsync();
        }

        public async Task<BabyGift> getGiftFromIdAsync(long? giftId)
        {
            return await dbContext.BabyGifts
                .Where(x => x.giftId == giftId)
                .FirstOrDefaultAsync();
        }
        #endregion
    }
}
