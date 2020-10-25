using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace asagiv.dbmanager.addresses
{
    public class Person
    {
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
        public DateTime dateOfBirth { get; set; }
        public Family family 
        {
            get => _lazyLoader.Load(this, ref _family);
            set => _family = value;
        }
        #endregion

        #region Constructor
        public Person() { }

        public Person(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }
        #endregion
    }
}
