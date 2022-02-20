using asagiv.common.mongodb;
using System;

namespace asagiv.dbmanager.common.Models
{
    public class EventInfo : MongoDbModelBase
    {
        public string EventName { get; set; }
        public string Description { get; set; }
        public DateTime? EventDate { get; set; }
    }
}
