using System;
using System.Collections.Generic;

namespace asagiv.dbmanager.babythankyounotes
{
    public partial class PeopleBabyGifts
    {
        public long? PeopleId { get; set; }
        public long? BabyGiftId { get; set; }
        public long PeopleBabyGiftId { get; set; }

        public virtual BabyGifts BabyGift { get; set; }
        public virtual People People { get; set; }
    }
}
