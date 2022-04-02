using asagiv.common.mongodb;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public sealed class AddressBookDatabase : MongoDbDatabaseBase
    {
        #region Statics
        private static readonly Lazy<AddressBookDatabase> _lazyInstance = new(() => new AddressBookDatabase());
        public static AddressBookDatabase Instance => _lazyInstance.Value;
        #endregion

        #region Constructor
        private AddressBookDatabase() : base(MongoDbClient.Instance, "AddressBook") { }
        #endregion
    }
}
