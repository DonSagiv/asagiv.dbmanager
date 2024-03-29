﻿using System.Linq;
using asagiv.common.mongodb;
using MongoDB.Bson;
using System.Collections.Generic;

namespace asagiv.dbmanager.common.Models
{
    public class Address : MongoDbModelBase
    {
        private bool isPrimary;
        #region Properties
        public ObjectId FamilyId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool IsPrimary { get; set; }
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
                lines.AddRange(Street.Split('\r', '\n'));
            }

            if (Country == "USA")
            {
                lines.Add($"{City}, {State} {Zip}");
            }
            else
            {
                lines.Add($"{City}, {Country} {Zip}");
            }

            return lines
                .Select(x => x.Trim()) // Remove all whitespace
                .ToArray();
        }

        public override string ToString()
        {
            return string.Join('\n', GetLines());
        }
        #endregion
    }
}
