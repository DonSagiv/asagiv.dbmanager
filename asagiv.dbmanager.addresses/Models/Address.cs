﻿using asagiv.common.mongodb;
using MongoDB.Bson;
using System.Collections.Generic;

namespace asagiv.dbmanager.common.Models
{
    public class Address : MongoDbModelBase
    {
        #region Properties
        public ObjectId FamilyId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        #endregion

        #region Constructor
        public Address() { }
        #endregion

        #region Methods
        public string[] GetLines()
        {
            var lines = new List<string>();

            if (!string.IsNullOrWhiteSpace(Street))
            {
                foreach (var streetLine in Street.Split('\r', '\n'))
                {
                    lines.Add(streetLine);
                }
            }

            if (Country == "USA")
            {
                lines.Add($"{City}, {State} {Zip}");
            }
            else
            {
                lines.Add($"{City}, {Country} {Zip}");
            }

            return lines.ToArray();
        }

        public override string ToString()
        {
            return string.Join('\n', GetLines());
        }
        #endregion
    }
}
