using System;
using System.ComponentModel.DataAnnotations;

namespace asagiv.dbmanager.addresses
{
    public class BabyGift
    {
        [Key]
        public long giftId { get; set; }
        public string giftDescription { get; set; }
    }
}
