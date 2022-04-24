using asagiv.common.mongodb;
using asagiv.dbmanager.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asagiv.dbmanager.common.MongoDB
{
    public class FamilyEventGiftCollection : MongoDbCollectionBase<FamilyEventGift>
    {
        public FamilyEventGiftCollection() : base(AddressBookDatabase.Instance, "FamilyEventGift") { }
    }
}
