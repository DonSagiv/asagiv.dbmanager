using asagiv.common.databases;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using Serilog;

namespace asagiv.dbmanager.common.MongoDB
{
    public class EventGiftCollection : MongoDbCollectionBase<EventGift>
    {
        public EventGiftCollection(IDbDatabase database, ILogger logger = null) : base(database, "EventGifts", logger) { }
    }
}
