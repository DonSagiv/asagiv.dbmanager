﻿using asagiv.common.mongodb;
using MongoDB.Bson;

namespace asagiv.dbmanager.common
{
    public class FamilyEventGift : MongoDbModelBase
    {
        #region Properties
        public ObjectId FamilyId { get; set; }
        public ObjectId EventGift { get; set; }
        public bool ThankYouNoteWritten { get; set; }
        #endregion

        #region Constructor
        public FamilyEventGift() { }
        #endregion
    }
}
