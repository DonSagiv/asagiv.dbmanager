using asagiv.dbmanager.babythankyounotes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asagiv.dbmanager
{
    internal static class DbFunctions
    {
        private static StreamWriter getStream()
        {
            var sw = new StreamWriter(@"C:\Users\DonSa\Desktop\Birth Announcement List.txt");

            /*
            var sw = new StreamWriter(Console.OpenStandardOutput());
            sw.AutoFlush = true;
            Console.SetOut(sw);
            */

            return sw;
        }

        public static async Task createAddressListAsync(MainDbContext dbContext)
        {
            var peopleList = await dbContext.People
                .Join(dbContext.RobertBabyAnnouncements,
                    p => p.PeopleId,
                    a => a.PeopleId,
                    (p, a) => new { p, a })
                .OrderBy(x => x.p.FamilyName)
                .ToDictionaryAsync(x => x.p, x => x.a);

            listPeople(peopleList);
        }

        public static void listPeople(IDictionary<People, RobertBabyAnnouncements> peopleList)
        {
            using var tw = getStream();

            foreach (var person in peopleList)
            {
                var name = string.IsNullOrWhiteSpace(person.Value?.CustomName)
                    ? person.Key.Name
                    : person.Value.CustomName;

                var stateCountry = person.Key.Country == "USA"
                    ? person.Key.State
                    : person.Key.Country;

                tw.WriteLine(name);
                tw.WriteLine(person.Key.Street);
                tw.WriteLine($"{person.Key.City}, {stateCountry}");
                if (!string.IsNullOrWhiteSpace(person.Key.Zip)) tw.WriteLine(person.Key.Zip);

                // Add space between addresses
                tw.WriteLine();
            }
        }

        public static async Task importAddressesAsync(MainDbContext dbContext, string fileName)
        {
            var importedCsvPeople = new List<List<string>>();

            using (var sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    int numCommas = 0;
                    var stringBuilder = new StringBuilder();

                    while (numCommas < 6)
                    {
                        var line = await sr.ReadLineAsync();

                        if (numCommas > 0)
                            stringBuilder.Append('\n');

                        stringBuilder.Append(line);

                        numCommas += stringBuilder
                            .ToString()
                            .Count(x => x == ',');
                    }

                    importedCsvPeople.Add(stringBuilder.ToString().Split(',').ToList());
                }
            };

            var headerColumn = importedCsvPeople.FirstOrDefault();

            if (headerColumn == null)
                throw new Exception("No data was found in this CSV file.");

            var nameColumn = headerColumn.FindIndex(x => x == "Name");
            var streetColumn = headerColumn.FindIndex(x => x == "Address");
            var cityColumn = headerColumn.FindIndex(x => x == "City");
            var stateColumn = headerColumn.FindIndex(x => x == "State");
            var zipColumn = headerColumn.FindIndex(x => x == "ZIP");
            var countryColumn = headerColumn.FindIndex(x => x == "Country");
            var familyNameColumn = headerColumn.FindIndex(x => x == "Family Name");

            var people = importedCsvPeople
                .Skip(1)
                .Where(x => x.Count == 7)
                .Select(personCsvRow =>
                {
                    var street = personCsvRow[streetColumn];

                    var country = string.IsNullOrWhiteSpace(personCsvRow[countryColumn])
                        ? null
                        : personCsvRow[countryColumn];

                    var zip = personCsvRow[zipColumn].ToString();

                    while (zip.Count() < 5)
                    {
                        zip = zip.Insert(0, "0");
                    }

                    return new People()
                    {
                        Name = personCsvRow[nameColumn],
                        Street = street,
                        City = personCsvRow[cityColumn],
                        State = personCsvRow[stateColumn],
                        Zip = personCsvRow[zipColumn],
                        Country = country,
                        FamilyName = personCsvRow[familyNameColumn],
                    };
                })
                .ToList();

            await dbContext.People.AddRangeAsync(people);
            await dbContext.SaveChangesAsync();
        }

        public static async Task addPeopleToBirthAnnouncementsAsync(MainDbContext dbContext)
        {
            var announcementIds = await dbContext
                .RobertBabyAnnouncements
                .Select(x => x.PeopleId)
                .ToListAsync();

            var peopleWithoutAnnouncements = await dbContext
                .People
                .Where(x => !announcementIds.Contains(x.PeopleId))
                .OrderBy(x => x.FamilyName)
                .ToListAsync();

            foreach (var person in peopleWithoutAnnouncements)
            {
                Console.Write($"Would you like to add {person.Name}?: ");
                var result = Console.ReadLine();

                if (result != "y") continue;

                dbContext.RobertBabyAnnouncements.Add(new RobertBabyAnnouncements
                {
                    PeopleId = person.PeopleId
                });
            }

            dbContext.SaveChanges();
        }

        public static async Task addCustomNameAsync(MainDbContext dbContext)
        {
            Console.WriteLine("Add a custom name");

            Console.Write("Type in the family name: ");
            var familyName = Console.ReadLine();

            var person = getPersonFromFamilyName(dbContext, familyName);

            if (person == null) return;

            var announcement = await dbContext
                .RobertBabyAnnouncements
                .FirstOrDefaultAsync(x => x.PeopleId == person.PeopleId);

            if (announcement == null)
            {
                Console.WriteLine("Could not find this person in the baby annoucements.");
                return;
            }

            Console.Write($"What custom name would you like to assign to {person.Name}?: ");
            var customName = Console.ReadLine();

            if (customName == "null")
                customName = null;

            Console.Write($"Do you want to set the name {customName} to {person.Name}? (y/n): ");
            var checkResult = Console.ReadLine();

            if (checkResult != "y") return;

            announcement.CustomName = customName;

            await dbContext.SaveChangesAsync();
        }


        public static async Task addGiftAsync(MainDbContext dbContext)
        {
            Console.WriteLine("Add a baby gift.");

            while (true)
            {
                Console.Write("Type in the name of the baby gift: ");
                var gift = Console.ReadLine();

                Console.Write("Type in the family name of the giver: ");
                var familyName = Console.ReadLine();

                var person = getPersonFromFamilyName(dbContext, familyName);

                if (person == null) return;

                Console.Write($"Did {person.Name} get you {gift}? (y/n): ");
                var response = Console.ReadLine();

                if (response != "y") continue;

                var babyGift = new BabyGifts { Gift = gift };

                await dbContext.BabyGifts.AddAsync(babyGift);

                await dbContext.PeopleBabyGifts.AddAsync(new PeopleBabyGifts
                {
                    People = person,
                    BabyGift = babyGift,
                });

                await dbContext.SaveChangesAsync();

                break;
            }
        }

        private static People getPersonFromFamilyName(MainDbContext dbContext, string familyName)
        {
            People person = null;

            using (var peopleEnumerator = dbContext
                .People
                .Where(x => x.FamilyName.ToLower() == familyName.ToLower())
                .GetEnumerator())
            {
                while (peopleEnumerator.MoveNext())
                {
                    person = peopleEnumerator.Current;
                    Console.Write($"Is it {person.Name} from {person.City},{person.State ?? person.Country} (y/n)?: ");
                    var peopleResponse = Console.ReadLine();

                    if (peopleResponse == "y")
                        return person;
                }
            }

            Console.WriteLine("Could not find a person with this family name.");

            return person;
        }
    }
}
