using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;

namespace asagiv.dbmanager.common.MongoDB
{
    public class EventGiftCollection : MongoDbCollectionBase<EventGift>
    {
        public EventGiftCollection() : base(AddressBookDatabase.Instance, "EventGifts") { }
    }
}
