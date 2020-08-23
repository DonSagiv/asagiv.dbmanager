using System;
using System.Collections.Generic;
using System.Text;

namespace asagiv.dbmanager.babythankyounotes
{
    public class BabyGiftList
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string Gift { get; set; }
        public bool? TyNoteWritten { get; set; }

        public string GetAddressString()
        {
            var sb = new StringBuilder();

            var stateCountry = Country == "USA" ? State : Country;

            sb.AppendLine(Name);
            sb.AppendLine(Street);
            sb.AppendLine($"{City}, {stateCountry}");
            if (!string.IsNullOrWhiteSpace(Zip))
                sb.AppendLine(Zip);

            return sb.ToString();
        }
    }
}
