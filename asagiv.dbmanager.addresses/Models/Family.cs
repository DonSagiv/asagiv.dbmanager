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
        [BsonIgnore]
        public IList<Person> People { get; set; }
        #endregion

        #region Constructor
        public Family()
        {
            Addresses = new List<Address>();
            People = new List<Person>();
        }
        #endregion
    }
}