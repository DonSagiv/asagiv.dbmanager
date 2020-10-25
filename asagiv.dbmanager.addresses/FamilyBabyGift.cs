using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asagiv.dbmanager.addresses
{
    public class FamilyBabyGift
    {
        #region Fields
        private readonly ILazyLoader _lazyLoader;

        private Family _family;
        private BabyGift _babyGift;
        #endregion

        #region Properties
        [Key]
        public long familyBabyGiftId { get; set; }
        [ForeignKey(nameof(family))]
        public long familyId { get; set; }
        [ForeignKey(nameof(babyGift))]
        public long babyGiftId { get; set; }
        public bool thankYouNoteWritten { get; set; }
        public Family family 
        {
            get => _lazyLoader.Load(this, ref _family);
            set => _family = value;
        }
        public BabyGift babyGift
        {
            get => _lazyLoader.Load(this, ref _babyGift);
            set => _babyGift = value;
        }
        #endregion

        #region Constructor
        public FamilyBabyGift() { }

        public FamilyBabyGift(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        #endregion
    }
}
