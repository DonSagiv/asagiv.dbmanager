using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public class FamilyCollection : MongoDbCollectionBase<Family>
    {
        #region Constructor
        public FamilyCollection() : base(AddressBookDatabase.Instance, "Families") { }
        #endregion
    }
}
