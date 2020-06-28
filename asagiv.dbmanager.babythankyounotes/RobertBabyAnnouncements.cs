using System;
using System.Collections.Generic;

namespace asagiv.dbmanager.babythankyounotes
{
    public partial class RobertBabyAnnouncements
    {
        public long AnnouncementId { get; set; }
        public long? PeopleId { get; set; }
        public string CustomName { get; set; }

        public virtual People People { get; set; }
    }
}
