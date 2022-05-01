using asagiv.common.databases;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using Serilog;

namespace asagiv.dbmanager.common.MongoDB
{
    public class EventsCollection : MongoDbCollectionBase<EventInfo>
    {
        #region Constructor
        public EventsCollection(IDbDatabase database, ILogger logger = null) : base(database, "Events", logger) { }
        #endregion
    }
}
