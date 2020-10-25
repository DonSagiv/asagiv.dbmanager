using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asagiv.dbmanager.addresses
{
    public class FamilyBabyGift
    {
        #region Properties
        [Key]
        public long familyBabyGiftId { get; set; }
        [ForeignKey(nameof(family))]
        public long familyId { get; set; }
        [ForeignKey(nameof(babyGift))]
        public long babyGiftId { get; set; }
        public bool thankYouNoteWritten { get; set; }
        public Family family { get; set; }
        public BabyGift babyGift { get; set; }
        #endregion

        #region Constructor
        public FamilyBabyGift() { }
        #endregion
    }
}
