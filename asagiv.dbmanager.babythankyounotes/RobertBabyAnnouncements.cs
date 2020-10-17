using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asagiv.dbmanager.babythankyounotes
{
    public partial class RobertBabyAnnouncements
    {
        public long AnnouncementId { get; set; }
        public long? PeopleId { get; set; }
        public string CustomName { get; set; }

        public virtual People People { get; set; }

        public string ToAddressString()
        {
            var sb = new StringBuilder();

            var name = string.IsNullOrWhiteSpace(CustomName) ? People.Name : CustomName;
            var stateCountry = People.Country == "USA" ? People.State : People.Country;

            sb.AppendLine(name);
            sb.AppendLine(People.Street);
            sb.AppendLine($"{People.City}, {stateCountry}");
            if (!string.IsNullOrWhiteSpace(People.Zip))
                sb.AppendLine(People.Zip);

            return sb.ToString();
        }
    }
}
