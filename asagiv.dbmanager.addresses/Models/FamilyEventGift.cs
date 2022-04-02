using asagiv.common.mongodb;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace asagiv.dbmanager.common.Models
{
    public class FamilyEventGift : MongoDbModelBase
    {
        private Family family;
        private EventInfo eventInfo;
        private EventGift eventGift;
        #region Properties
        public ObjectId FamilyId { get; set; }
        public ObjectId EventId { get; set; }
        public ObjectId GiftId { get; set; }
        public bool ThankYouNoteWritten { get; set; }
        public string Notes { get; set; }
        [BsonIgnore]
        public Family Family
        {
            get => family;
            set
            {
                family = value;
                FamilyId = family?.Id ?? ObjectId.Empty;
            }
        }
        [BsonIgnore]
        public EventInfo EventInfo
        {
            get => eventInfo;
            set
            {
                eventInfo = value;
                EventId = eventInfo?.Id ?? ObjectId.Empty;
            }
        }
        [BsonIgnore]
        public EventGift EventGift
        {
            get => eventGift;
            set
            {
                eventGift = value;
                GiftId = eventGift?.Id ?? ObjectId.Empty;
            }
        }
        #endregion

        #region Constructor
        public FamilyEventGift() { }
        #endregion
    }
}
