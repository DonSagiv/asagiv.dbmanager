using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asagiv.dbmanager.addresses
{
    public class Family
    {
        [Key]
        public long familyId { get; set; }
        public string familyName { get; set; }
        public string addressHeader { get; set; }
        public virtual IList<Person> familyMembers { get; set; }
        public virtual IList<Address> addresses { get; set; }
    }
}
