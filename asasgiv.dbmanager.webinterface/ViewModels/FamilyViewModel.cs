using asagiv.dbmanager.addresses;
using System.Text;

namespace asagiv.dbmanager.webinterface.ViewModels
{
    public class FamilyViewModel
    {
        public Family family { get; }
        public bool isVisible { get; set; }

        public FamilyViewModel(Family familyInput)
        {
            family = familyInput;
        }

        public string[] getAddressLines()
        {
            var sb = new StringBuilder();

            foreach (var address in family.addresses)
            {
                sb.AppendLine(address.ToString());
                sb.AppendLine("  ");
            }

            return sb.ToString().Split('\n');
        }

        public string[] getPeopleLines()
        {
            var sb = new StringBuilder();

            foreach (var person in family.familyMembers)
            {
                sb.AppendLine(person.ToString());
            }

            return sb.ToString().Split('\n');
        }
    }
}
