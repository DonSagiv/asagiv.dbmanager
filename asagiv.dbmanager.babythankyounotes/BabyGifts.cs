using System;
using System.Collections.Generic;

namespace asagiv.dbmanager.babythankyounotes
{
    public partial class BabyGifts
    {
        public BabyGifts()
        {
            PeopleBabyGifts = new HashSet<PeopleBabyGifts>();
        }

        public long BabyGiftId { get; set; }
        public string Gift { get; set; }
        public bool TyNoteWritten { get; set; }

        public virtual ICollection<PeopleBabyGifts> PeopleBabyGifts { get; set; }
    }
}
