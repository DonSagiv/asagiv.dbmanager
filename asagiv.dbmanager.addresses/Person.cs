using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asagiv.dbmanager.addresses
{
    public class Person
    {
        [Key]
        public long personId { get; set; }
        [ForeignKey(nameof(family))]
        public long familyId { get; set; }
        public string personName { get; set; }
        public DateTime dateOfBirth { get; set; }

        public Family family { get; set; }
    }
}
