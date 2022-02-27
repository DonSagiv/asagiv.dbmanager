using asagiv.common.mongodb;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace asagiv.dbmanager.common.Models
{
    public class Family : MongoDbModelBase
    {
        #region Properties
        public string FamilyName { get; set; }
        public string AddressHeader { get; set; }
        [BsonIgnore]
        public IList<Address> Addresses { get; set; }
        #endregion

        #region Constructor
        public Family() { }
        #endregion
    }
}