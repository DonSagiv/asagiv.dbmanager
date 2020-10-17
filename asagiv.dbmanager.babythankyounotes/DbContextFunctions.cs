using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asagiv.dbmanager.babythankyounotes
{
    public static class DbContextFunctions
    {
        public static async Task<string> createAnnouncementAddressList(MainDbContext dbContext)
        {
            var peopleList = await dbContext.People
                .Join(dbContext.RobertBabyAnnouncements,
                    p => p.PeopleId,
                    a => a.PeopleId,
                    (p, a) => new { p, a })
                .OrderBy(x => x.p.FamilyName)
                .ToDictionaryAsync(x => x.p, x => x.a);

            return listPeople(peopleList);
        }

        public static async Task<string> createBabyGiftList(MainDbContext dbContext)
        {
            var babyGiftList = await dbContext
                .PeopleBabyGifts
                .Where(x => x.BabyGift.TyNoteWritten == false)
                .ToListAsync();

            return await listGifts(babyGiftList, dbContext);
        }

        public static string listPeople(IDictionary<People, RobertBabyAnnouncements> peopleList)
        {
            var sb = new StringBuilder();

            foreach (var person in peopleList)
            {
                var name = string.IsNullOrWhiteSpace(person.Value?.CustomName)
                    ? person.Key.Name
                    : person.Value.CustomName;

                var stateCountry = person.Key.Country == "USA"
                    ? person.Key.State
                    : person.Key.Country;

                sb.AppendLine(name);
                sb.AppendLine(person.Key.Street);
                sb.AppendLine($"{person.Key.City}, {stateCountry}");
                if (!string.IsNullOrWhiteSpace(person.Key.Zip)) sb.AppendLine(person.Key.Zip);

                // Add space between addresses
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public static async Task<string> listGifts(IList<PeopleBabyGifts> babyGifts, MainDbContext dbContext)
        {
            var sb = new StringBuilder();

            foreach (var babyGift in babyGifts)
            {
                var gift = babyGift?.BabyGift ?? await dbContext.BabyGifts.FirstOrDefaultAsync(x => x.BabyGiftId == babyGift.BabyGiftId);
                var person = babyGift?.People ?? await dbContext.People.FirstOrDefaultAsync(x => x.PeopleId == babyGift.PeopleId);

                sb.AppendLine($"Gift: {gift.Gift}");
                sb.AppendLine(person.ToAddressString());

                // Add space between addresses
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
