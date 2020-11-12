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
            var ipAddress = Environment.GetEnvironmentVariable("DB_IP");
            var port = Environment.GetEnvironmentVariable("DB_PORT");
            var database = Environment.GetEnvironmentVariable("DB_NAME");
            var userName = Environment.GetEnvironmentVariable("DB_USERNAME");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            if (password == "empty")
                throw new Exception("Invalid database password.");

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
                .Where(x => x.ToSearchableString().ToLower().Contains(filterString.ToLower()))
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

        public async Task addGiftAsync(BabyGift babyGift, IList<FamilyBabyGift> familyBabyGiftsToSave)
        {
            if (!(await dbContext.BabyGifts.ContainsAsync(babyGift)))
                await dbContext.BabyGifts.AddAsync(babyGift);

            var oldFamilyBabyGifts = await dbContext.FamilyBabyGifts
                .Where(x => x.babyGift == babyGift)
                .ToListAsync();

            var familyBabyGiftsToRemove = oldFamilyBabyGifts.Except(familyBabyGiftsToSave).ToList();
            dbContext.FamilyBabyGifts.RemoveRange(familyBabyGiftsToRemove);
            dbContext.FamilyBabyGifts.UpdateRange(familyBabyGiftsToSave);

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

        public async Task<IList<FamilyBabyGift>> getPeopleFromGift(BabyGift babyGift)
        {
            return await dbContext.FamilyBabyGifts
                .Where(x => x.babyGiftId == babyGift.giftId)
                .ToListAsync();
        }

        public async Task<BabyGift> getGiftFromIdAsync(long? giftId)
        {
            return await dbContext.BabyGifts
                .Where(x => x.giftId == giftId)
                .FirstOrDefaultAsync();
        }

        public async Task deleteFamilyBabyGift(FamilyBabyGift e)
        {
            dbContext.FamilyBabyGifts.Remove(e);

            var anyGifts = await dbContext
                .FamilyBabyGifts
                .Where(x => x != e)
                .AnyAsync(x => e.babyGiftId == x.babyGiftId);

            if(anyGifts == false)
                dbContext.BabyGifts.Remove(e.babyGift);

            await dbContext.SaveChangesAsync();
        }

        public async Task setTyNoteWritten(FamilyBabyGift e)
        {
            e.thankYouNoteWritten = !e.thankYouNoteWritten;

            dbContext.FamilyBabyGifts.Update(e);

            await dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
