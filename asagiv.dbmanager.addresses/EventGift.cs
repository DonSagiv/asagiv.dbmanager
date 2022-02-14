using asagiv.common.mongodb;
using MongoDB.Bson;

namespace asagiv.dbmanager.common
{
    public class EventGift : MongoDbModelBase
    {
        public ObjectId FamilyId { get; set; }
        public string GiftDescription { get; set; }
    }
}
