using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace Services
{
    public class CSVService: ICSVService
    {
        public List<AutoHouseModel> ReadTradesFromFile(string filename)
        {
            
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AutoHouseModel>().ToList();
                return records;
            }

        }
    }
}