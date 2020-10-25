using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asagiv.dbmanager.addresses
{
    public class Address
    {
        #region Fields
        private readonly ILazyLoader _lazyLoader;

        private Family _family;
        #endregion

        #region Properties
        [Key]
        public long addressId { get; set; }
        [ForeignKey(nameof(family))]
        public long familyId { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        [StringLength(2, MinimumLength = 2, ErrorMessage = "State must be 2 letter abbreviation")]
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public Family family 
        {
            get => _lazyLoader.Load(this, ref _family);
            set => _family = value;
        }
        #endregion

        #region Constructor
        public Address() { }

        public Address(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        #endregion
    }
}
