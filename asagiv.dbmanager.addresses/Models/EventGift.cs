using asagiv.common.mongodb;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace asagiv.dbmanager.common.Models
{
    public class EventGift : MongoDbModelBase
    {
        public string GiftDescription { get; set; }
        public string Notes { get; set; }
    }
}
