using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public class AddressCollection : MongoDbCollectionBase<Address>
    {
        #region Constructor
        public AddressCollection() : base(AddressBookDatabase.Instance, "Addresses") { }
        #endregion
    }
}
