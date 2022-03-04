using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asagiv.dbmanager.common.MongoDB
{
    public class EventsCollection : MongoDbCollectionBase<EventInfo>
    {
        #region Constructor
        public EventsCollection() : base(AddressBookDatabase.Instance, "Events") { }
        #endregion
    }
}
