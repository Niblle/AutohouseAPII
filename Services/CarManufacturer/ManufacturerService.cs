using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.CarManufacturer
{
    public class ManufacturerService : IManufacturerService
    {
        public readonly AutoHouseContext _autoHouseContext;
        public ManufacturerService(AutoHouseContext autoHouseContext)
        {
            _autoHouseContext = autoHouseContext;
        }
        public bool Delite(int id)
        {
            Manufacturer? manufacturer = _autoHouseContext.Manufacturers.FirstOrDefault(x => x.Id == id);
            if (manufacturer == null)
            {
                return false;
            }
            _autoHouseContext.Remove(manufacturer);
            _autoHouseContext.SaveChanges();
            return true;
        }

        public List<Manufacturer> GetModels()
        {
            List<Manufacturer> manufacturers = _autoHouseContext.Manufacturers.ToList();
            return manufacturers;
        }

        public bool Update(int id, ManufacturerViewModel model)
        {
            Manufacturer? manufacturer = _autoHouseContext.Manufacturers.FirstOrDefault(x => x.Id == id);

            if (manufacturer == null)
            {
                return false;
            }
            manufacturer.Name = model.Name;
            

            _autoHouseContext.SaveChanges();
            return true;
        }
    }
}
