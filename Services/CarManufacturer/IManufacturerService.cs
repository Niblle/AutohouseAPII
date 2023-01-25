using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.CarManufacturer
{
    public interface IManufacturerService
    {
        public bool Delite(int id);
        public List<Manufacturer> GetModels();
        public bool Update(int id, ManufacturerViewModel model);
    }
}
