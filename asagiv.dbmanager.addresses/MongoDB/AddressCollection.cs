using asagiv.common.databases;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using Serilog;

namespace asagiv.dbmanager.common.MongoDB
{
    public class AddressCollection : MongoDbCollectionBase<Address>
    {
        #region Constructor
        public AddressCollection(IDbDatabase database, ILogger logger = null) : base(database, "Addresses", logger) { }
        #endregion
    }
}
