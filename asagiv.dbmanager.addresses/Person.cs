﻿using asagiv.common.mongodb;
using MongoDB.Bson;
using System;

namespace asagiv.dbmanager.common
{
    public class Person : MongoDbModelBase
    {
        #region Properties
        public ObjectId FamilyId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        #endregion

        #region Constructor
        public Person() { }
        #endregion
    }
}
