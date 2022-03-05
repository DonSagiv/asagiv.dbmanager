using asagiv.common.mongodb;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace asagiv.dbmanager.common.Models
{
    public class FamilyEventGift : MongoDbModelBase
    {
        #region Properties
        public ObjectId FamilyId { get; set; }
        public ObjectId EventId { get; set; }
        public ObjectId GiftId { get; set; }
        public bool ThankYouNoteWritten { get; set; }
        public string Notes { get; set; }
        [BsonIgnore]
        public Family Family { get; set; }
        [BsonIgnore]
        public EventInfo EventInfo { get; set; }
        [BsonIgnore]
        public EventGift EventGift { get; set; }
        #endregion

        #region Constructor
        public FamilyEventGift() { }
        #endregion
    }
}
