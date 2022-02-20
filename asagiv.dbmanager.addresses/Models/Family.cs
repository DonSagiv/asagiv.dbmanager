using asagiv.common.mongodb;

namespace asagiv.dbmanager.common.Models
{
    public class Family : MongoDbModelBase
    {
        #region Properties
        public string FamilyName { get; set; }
        public string AddressHeader { get; set; }
        #endregion

        #region Constructor
        public Family() { }
        #endregion
    }
}