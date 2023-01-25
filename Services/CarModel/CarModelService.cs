using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.CarModel
{
    public class CarModelService : ICarModelService
    {
        public readonly AutoHouseContext _autoHouseContext;
        public CarModelService(AutoHouseContext autoHouseContext)
        {
            _autoHouseContext = autoHouseContext;
        }

        public bool Delite(int id)
        {
            Model? carModel = _autoHouseContext.Models.FirstOrDefault(x => x.Id == id);
            if (carModel == null)
            {
                return false;
            }
            _autoHouseContext.Remove(carModel);
            _autoHouseContext.SaveChanges();
            return true;
        }

        public List<Model> GetModels()
        {
            List<Model> carModels = _autoHouseContext.Models.ToList();
            return carModels;
        }
        public bool Update(int id, ModelViewModel model)
        {
            Model? carModel = _autoHouseContext.Models.FirstOrDefault(x => x.Id == id);
            int manufacturerId = _autoHouseContext.Manufacturers.Where(x => x.Name == model.Manufacturer).FirstOrDefault()?.Id??0;
            if (carModel == null && model == null && manufacturerId == 0)
            {
                return false;
            }
            carModel.ManufacturerId = manufacturerId;
            carModel.Name = model.Name;
            carModel.VehicleType = model.VehicleType;
            carModel.CarSpecificationId = carModel.Id;
            _autoHouseContext.SaveChanges();
            return true;

        }
    }
}
