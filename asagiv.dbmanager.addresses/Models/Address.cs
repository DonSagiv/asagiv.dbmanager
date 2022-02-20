using asagiv.common.mongodb;
using MongoDB.Bson;

namespace asagiv.dbmanager.common.Models
{
    public class Address : MongoDbModelBase
    {
        #region Properties
        public ObjectId FamilyId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        #endregion

        #region Constructor
        public Address() { }
        #endregion
    }
}
