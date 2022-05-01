using asagiv.common.databases;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using Serilog;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public class FamilyCollection : MongoDbCollectionBase<Family>
    {
        #region Constructor
        public FamilyCollection(IDbDatabase database, ILogger logger = null) : base(database, "Families", logger) { }
        #endregion
    }
}
