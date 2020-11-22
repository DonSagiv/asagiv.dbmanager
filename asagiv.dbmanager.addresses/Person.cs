using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asagiv.dbmanager.addresses
{
    public class Person
    {
        #region Statics
        private static readonly DateTime zeroTime = new DateTime(1, 1, 1);
        #endregion

        #region Fields
        private readonly ILazyLoader _lazyLoader;

        private Family _family;
        #endregion

        #region Properties
        [Key]
        public long personId { get; set; }
        [ForeignKey(nameof(family))]
        public long familyId { get; set; }
        public string personName { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public Family family
        {
            get => _lazyLoader.Load(this, ref _family);
            set => _family = value;
        }
        [NotMapped]
        public int? age => getAge();
        #endregion

        #region Constructor
        public Person() { }

        public Person(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        #endregion

        #region Methods
        private int? getAge()
        {
            if (dateOfBirth == null)
                return null;

            var ageSpan = DateTime.Now - dateOfBirth;
            return (zeroTime + ageSpan.Value).Year - 1;
        }

        public override string ToString()
        {
            return age == null
                ? personName
                : $"{personName} ({age})";
        }
        #endregion
    }
}
