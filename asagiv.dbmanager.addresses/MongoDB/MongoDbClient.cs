using asagiv.common.mongodb;
using System;

namespace asagiv.dbmanager.common.MongoDB
{
    public sealed class MongoDbClient : MongoDbClientBase
    {
        #region Statics
        private static readonly Lazy<MongoDbClient> _lazyInstance = new(() => new MongoDbClient());
        public static MongoDbClient Instance => _lazyInstance?.Value;
        #endregion

        #region Constructor
        private MongoDbClient() { }
        #endregion
    }
}
