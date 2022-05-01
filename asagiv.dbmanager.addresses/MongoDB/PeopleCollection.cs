using asagiv.common.databases;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using Serilog;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public class PeopleCollection : MongoDbCollectionBase<Person>
    {
        #region Constructor
        public PeopleCollection(IDbDatabase database, ILogger logger = null) : base(database, "People", logger) { }
        #endregion
    }
}