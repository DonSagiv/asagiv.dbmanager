using asagiv.common.databases;
using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asagiv.dbmanager.common.MongoDB
{
    public class FamilyEventGiftCollection : MongoDbCollectionBase<FamilyEventGift>
    {
        public FamilyEventGiftCollection(IDbDatabase database, ILogger logger = null) : base(database, "FamilyEventGift", logger) { }
    }
}
