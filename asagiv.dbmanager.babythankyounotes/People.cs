using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asagiv.dbmanager.babythankyounotes
{
    public partial class People
    {
        #region Statics
        public const string toStringRegex = @"(.*) \((.*), (.*)\)";
        #endregion

        public People()
        {
            PeopleBabyGifts = new HashSet<PeopleBabyGifts>();
            RobertBabyAnnouncements = new HashSet<RobertBabyAnnouncements>();
        }

        [Required]
        public long PeopleId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be 2 latter abbreviation")]
        public string State { get; set; }
        [StringLength(5, MinimumLength = 2, ErrorMessage = "ZIP must have 5 numerical characters")]
        public string Zip { get; set; }
        public string Country { get; set; }
        public string FamilyName { get; set; }

        public virtual ICollection<PeopleBabyGifts> PeopleBabyGifts { get; set; }
        public virtual ICollection<RobertBabyAnnouncements> RobertBabyAnnouncements { get; set; }

        #region Methods
        public override string ToString()
        {
            var stateCountry = string.IsNullOrWhiteSpace(State) ? Country : State;
            return $"{Name} ({City}, {stateCountry})";
        }

        public string ToInfoString()
        {
            return $"{Name} {Street} {City} {State} {Country} {Zip} {FamilyName}".ToLower();
        }
        #endregion
    }
}
