using System;
using asagiv.dbmanager.babythankyounotes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace asagiv.dbmanager.webinterface.Data
{
    public class MainDbContextService
    {
        #region Properties
        public MainDbContext dbContext { get; private set; }
        #endregion

        #region Constructor
        public MainDbContextService()
        {
            dbContext = new MainDbContext();
        }
        #endregion

        #region Methods
        public async Task<IList<People>> getPeopleAsync()
        {
            return await dbContext.People
                .OrderBy(x => x.FamilyName)
                .ToListAsync();
        }

        public async Task<IList<string>> getPeopleNamesAsync()
        {
            Func<People, string> getStateCountry = x => string.IsNullOrWhiteSpace(x.State) ? x.Country : x.State;

            return await dbContext.People
                .OrderBy(x => x.FamilyName)
                .Select(x => x.ToString())
                .ToListAsync();
        }

        public async Task<People> getPersonFromIdAsync(long personId)
        {
            return await dbContext.People
                .FirstOrDefaultAsync(x => x.PeopleId == personId);
        }

        public async Task savePersonAsync(People person)
        {
            if (!dbContext.People.Contains(person))
                await dbContext.People.AddAsync(person);

            await dbContext.SaveChangesAsync();
        }

        public async Task<IList<BabyGiftList>> getBabyGiftListAsync()
        {
            return await dbContext.BabyGiftList
                .OrderBy(x => x.TyNoteWritten)
                .ThenBy(x => x.Gift)
                .ToListAsync();
        }

        public async Task addGiftAsync(BabyGifts babyGift, IList<string> peopleList)
        {
            if (!(await dbContext.BabyGifts.ContainsAsync(babyGift)))
                await dbContext.BabyGifts.AddAsync(babyGift);

            var peopleFiltered = peopleList
                .Select(x => Regex.Match(x, People.toStringRegex))
                .Select(x => new string[] { x.Groups[1].Value, x.Groups[2].Value, x.Groups[3].Value })
                .ToList();

            var people = await dbContext.People
                .Where(x => peopleFiltered.Select(y => y[0]).Contains(x.Name))
                .Where(x => peopleFiltered.Select(y => y[1]).Contains(x.City))
                .Where(x => peopleFiltered.Select(y => y[2]).Contains(string.IsNullOrWhiteSpace(x.State) ? x.Country : x.State))
                .ToListAsync();

            var peopleBabyGifts = await dbContext.PeopleBabyGifts
                .Where(x => x.BabyGift == babyGift)
                .Select(x => x.People)
                .ToListAsync();

            var peopleToAdd = people.Except(peopleBabyGifts).ToList();
            var peopleToRemove = peopleBabyGifts.Except(people).ToList();

            foreach (var person in peopleToAdd)
            {
                var peopleBabyGift = new PeopleBabyGifts
                {
                    BabyGift = babyGift,
                    People = person,
                };

                var peopleEntityEntry = await dbContext.PeopleBabyGifts.AddAsync(peopleBabyGift);
            }

            foreach (var person in peopleToRemove)
            {
                var removeList = dbContext.PeopleBabyGifts
                    .Where(x => x.People == person)
                    .Where(x => x.BabyGift == babyGift)
                    .ToList();

                foreach (var item in removeList)
                    dbContext.PeopleBabyGifts.Remove(item);
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task<long?> getGiftFromNameAsync(string giftName)
        {
            return await dbContext.BabyGifts
                .Where(x => x.Gift == giftName)
                .Select(x => x.BabyGiftId)
                .FirstOrDefaultAsync();
        }

        public async Task<IList<People>> getPeopleFromGift(BabyGifts babyGift)
        {
            return await dbContext.PeopleBabyGifts
                .Where(x => x.BabyGiftId == babyGift.BabyGiftId)
                .Select(x => x.People)
                .ToListAsync();
        }

        public async Task<BabyGifts> getGiftFromIdAsync(long? giftId)
        {
            return await dbContext.BabyGifts
                .Where(x => x.BabyGiftId == giftId)
                .FirstOrDefaultAsync();
        }

        public async Task<IList<RobertBabyAnnouncements>> getBabyAnnoucnementsAsync()
        {
            return await dbContext.RobertBabyAnnouncements
                .OrderBy(x => x.People.FamilyName)
                .ToListAsync();
        }

        public async Task<IList<string>> getPeopleWithoutAnnouncementsAsync(params string[] additionalPeopleToAdd)
        {
            var peopleIds = dbContext.People.Select(x => x.PeopleId);

            var announcementIds = dbContext.RobertBabyAnnouncements
                .Where(x => x.PeopleId != null)
                .Select(x => x.PeopleId.Value);

            var idsToAdd = peopleIds.Except(announcementIds).ToList();

            var peopleToAdd = await dbContext.People
                .Where(x => idsToAdd.Contains(x.PeopleId))
                .Select(x => x.ToString())
                .ToListAsync();

            foreach (var personToAdd in additionalPeopleToAdd)
                peopleToAdd.Add(personToAdd);

            return peopleToAdd;
        }

        public async Task appendPersonToBirthAnnoucnementsAsync(RobertBabyAnnouncements annoucementPerson, string personName)
        {
            var personRegexMatch = Regex.Match(personName, People.toStringRegex);

            var personToAdd = await dbContext.People
                .Where(x => personRegexMatch.Groups[1].Value == x.Name)
                .Where(x => personRegexMatch.Groups[2].Value == x.City)
                .FirstOrDefaultAsync(x => personRegexMatch.Groups[3].Value == (string.IsNullOrWhiteSpace(x.State) ? x.Country : x.State));

            annoucementPerson.People = personToAdd;

            if (!await dbContext.RobertBabyAnnouncements.ContainsAsync(annoucementPerson))
                await dbContext.RobertBabyAnnouncements.AddAsync(annoucementPerson);

            await dbContext.SaveChangesAsync();
        }

        public async Task<RobertBabyAnnouncements> getAnnouncementFromId(string announcementId)
        {
            var id = long.Parse(announcementId);

            return await dbContext.RobertBabyAnnouncements
                .FirstOrDefaultAsync(x => x.AnnouncementId == id);
        }

        public async Task<string> getBirthAnnouncementAddressListAsync()
        {
            return await DbContextFunctions.createAnnouncementAddressList(dbContext);
        }
        #endregion
    }
}
