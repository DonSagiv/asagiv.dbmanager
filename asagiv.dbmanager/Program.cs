using asagiv.dbmanager.addresses;
using asagiv.dbmanager.babythankyounotes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace asagiv.dbmanager
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dbContext = new AddressDbContext("192.168.1.4", "5432", "addresses", "asagiv", "kingkong");

            var person = await dbContext.Families.FirstOrDefaultAsync();

            var address = person.addresses.FirstOrDefault();

            await dbContext.SaveChangesAsync();

            // await UpdatePeopleDbContext(oldDbContext, dbContext);
            // await updateGiftsDbContext(oldDbContext, dbContext);
        }

        private static async Task updateGiftsDbContext(MainDbContext oldDbContext, AddressDbContext dbContext)
        {
            var peopleBabyGifts = await oldDbContext.PeopleBabyGifts.ToListAsync();

            foreach (var personGift in peopleBabyGifts)
            {
                var gift = await oldDbContext.BabyGifts.FirstOrDefaultAsync(x => x.BabyGiftId == personGift.BabyGiftId);
                var person = await oldDbContext.People.FirstOrDefaultAsync(x => x.PeopleId == personGift.PeopleId);

                if (gift == null || person == null)
                    throw new Exception("Unable to find record.");

                var family = dbContext.Families
                    .Where(x => x.addressHeader == person.Name)
                    .Where(x => x.addresses.FirstOrDefault().City == person.City)
                    .FirstOrDefault();

                var babyGift = new BabyGift
                {
                    giftDescription = gift.Gift
                };

                var familyBabyGift = new FamilyBabyGift
                {
                    family = family,
                    babyGift = babyGift,
                    thankYouNoteWritten = gift.TyNoteWritten
                };

                dbContext.BabyGifts.Add(babyGift);
                dbContext.FamilyBabyGifts.Add(familyBabyGift);
            }
        }

        private static async Task UpdatePeopleDbContext(MainDbContext oldDbContext, AddressDbContext dbContext)
        {
            foreach (var people in oldDbContext.People)
            {
                Console.WriteLine(people.Name);

                var family = new Family
                {
                    familyName = people.FamilyName,
                    addressHeader = people.Name,
                    addresses = new List<Address>
                    {
                        new Address
                        {
                            Street = people.Street,
                            City = people.City,
                            State = people.State,
                            Zip = people.Zip,
                            Country = people.Country,
                        }
                    },
                    familyMembers = new List<Person>()
                };

                await dbContext.Families.AddAsync(family);
            }
        }
    }
}
