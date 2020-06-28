using System;
using System.Collections.Generic;

namespace asagiv.dbmanager.babythankyounotes
{
    public partial class BabyGiftList
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Gift { get; set; }
        public bool? TyNoteWritten { get; set; }
    }
}
