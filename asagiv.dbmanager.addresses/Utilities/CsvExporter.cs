using asagiv.dbmanager.common.Services;
using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace asagiv.dbmanager.common.Utilities
{
    public class CsvExporter
    {
        private record FamilyRecord(string FamilyName, string AddressHeader, string Street, string City, string State, string Zip, string Country);

        public async Task ExportFamiliesToCsvAsync(AddressBookDbService addressBookDbService, MemoryStream stream)
        {
            using var sw = new StreamWriter(stream);
            using var writer = new CsvWriter(sw, CultureInfo.InvariantCulture);
            {
                var familiesEnumearble = addressBookDbService
                    .GetAllFamiliesAsync()
                    .Select(x => new FamilyRecord(x.FamilyName,
                        x.AddressHeader,
                        x.Addresses.FirstOrDefault(x => x.IsPrimary)?.Street,
                        x.Addresses.FirstOrDefault(x => x.IsPrimary)?.City,
                        x.Addresses.FirstOrDefault(x => x.IsPrimary)?.State,
                        x.Addresses.FirstOrDefault(x => x.IsPrimary)?.Zip,
                        x.Addresses.FirstOrDefault(x => x.IsPrimary)?.Country));

                writer.WriteField("Family Name");
                writer.WriteField("Address Header");
                writer.WriteField("Street");
                writer.WriteField("City");
                writer.WriteField("State");
                writer.WriteField("Zip");
                writer.WriteField("Country");

                await foreach (var family in familiesEnumearble)
                {
                    await writer.NextRecordAsync();

                    writer.WriteRecord(family);
                }
            }
        }
    }
}
