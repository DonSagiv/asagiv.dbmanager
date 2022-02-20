using asagiv.common.mongodb;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public class MongoDbClient : MongoDbClientBase
    {
        #region Statics
        private static readonly Lazy<MongoDbClient> _lazyInstance = new(() => new MongoDbClient());
        public static MongoDbClient Instance => _lazyInstance?.Value;
        #endregion
    }
}
