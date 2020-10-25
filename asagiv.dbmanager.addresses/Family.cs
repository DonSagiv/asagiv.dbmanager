using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace asagiv.dbmanager.addresses
{
    public class Family
    {
        #region Fields
        private ILazyLoader _lazyLoader;
        private IList<Person> _familyMembers;
        private IList<Address> _addresses;
        #endregion

        #region Properties
        [Key]
        public long familyId { get; set; }
        public string familyName { get; set; }
        public string addressHeader { get; set; }
        public virtual IList<Person> familyMembers 
        {
            get => _lazyLoader.Load(this, ref _familyMembers);
            set => _familyMembers = value;
        }
        public virtual IList<Address> addresses 
        {
            get => _lazyLoader.Load(this, ref _addresses);
            set => _addresses = value;
        }
        #endregion

        #region Constructor
        public Family() { }

        public Family(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        #endregion

        #region Methods
        public string ToInfoString()
        {
            var memberNames = string.Join(' ', familyMembers.Select(x => x.personName));

            return ($"{familyName} {addressHeader} {memberNames}");
        }
        #endregion
    }
}