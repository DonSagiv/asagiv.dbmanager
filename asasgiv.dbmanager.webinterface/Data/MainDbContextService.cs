﻿using System;
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

            var regexString = @"(.*) \((.*), (.*)\)";

            var peopleFiltered = peopleList
                .Select(x => Regex.Match(x, regexString))
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
        #endregion
    }
}
