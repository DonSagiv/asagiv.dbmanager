using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace asagiv.dbmanager.addresses
{
    public class Family
    {
        #region Fields
        private readonly ILazyLoader _lazyLoader;

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
        public Family()
        {
            _familyMembers = new List<Person>();
            _addresses = new List<Address>();
        }

        public Family(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return ToAddressString();
        }

        public string ToSearchableString()
        {
            var memberNames = string.Join(' ', familyMembers.Select(x => x.personName));
            var searchableString = $"{familyName} {addressHeader} {memberNames}";
            return searchableString;
        }

        public string ToAddressString()
        {
            var sb = new StringBuilder();

            var primaryAddress = addresses.FirstOrDefault();
            
            sb.AppendLine(addressHeader);
            sb.AppendLine(primaryAddress.ToString());
            
            return sb.ToString();
        }
        #endregion
    }
}