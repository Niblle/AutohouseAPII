using CsvHelper;
using Data;
using Data.Entities;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Globalization;

namespace Services
{
    public class CSVService: ICSVService
    {
        public readonly AutoHouseContext _context;
        public CSVService(AutoHouseContext context) 
        {
            _context = context;
        }
        public List<AutoHouseModel> ReadTradesFromFile(string filename)
        {
            
            using (var reader = new StreamReader(filename))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AutoHouseModel>().ToList();
                return records;
            }

        }
        public async Task DataFilling(List<AutoHouseModel> autoHouseModels)
        {
            foreach (AutoHouseModel models in autoHouseModels)
            {
                if (!_context.Manufacturers.Select(x => x.Name).Contains(models.Manufacturer))
                {
                    if (models.Manufacturer != null)
                    {
                        Manufacturer manufacturer = new Manufacturer { Name = models.Manufacturer };
                        _context.Add(manufacturer);
                    }
                }
                if (!_context.Models.Select(x => x.Name).Contains(models.Model))
                {
                    CarSpecification specification = new CarSpecification
                    {
                        EngineSize = models.EngineSize,
                        HoursePower = models.Horsepower,
                    };
                    _context.Add(specification);
                }
            }
            _context.SaveChanges();
            foreach (AutoHouseModel models in autoHouseModels)
            {
                int carId = _context.CarSpecifications.Where(c => c.HoursePower == models.Horsepower)?.FirstOrDefault().Id ?? 0;
                int manufacId = _context.Manufacturers.Where(c => c.Name == models.Manufacturer)?.FirstOrDefault().Id ?? 0;
                if (!_context.Models.Select(x => x.Name).Contains(models.Model))
                {
                    if (models.Model != null && models.VehicleType != null)
                    {
                        Model model = new Model()
                        {
                            Name = models.Model,
                            VehicleType = models.VehicleType,
                            CarSpecificationId = carId,
                            ManufacturerId = manufacId,
                        };
                        _context.Add(model);
                    }
                }
            }
            _context.SaveChanges();
        }
    }
}