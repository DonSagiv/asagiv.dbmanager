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
    }
}
