using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public class PeopleCollection : MongoDbCollectionBase<Person>
    {
        #region Constructor
        public PeopleCollection() : base(AddressBookDatabase.Instance, "People") { }
        #endregion
    }
}
