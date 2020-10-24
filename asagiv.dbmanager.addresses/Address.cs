using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asagiv.dbmanager.addresses
{
    public class Address
    {
        [Key]
        public long addressId { get; set; }
        [ForeignKey(nameof(family))]
        public long familyId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        [StringLength(2, MinimumLength =2, ErrorMessage="State must be 2 letter abbreviation")]
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public Family family { get; set;  }
    }
}
