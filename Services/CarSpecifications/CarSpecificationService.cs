using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.CarSpecifications
{
    public class CarSpecificationService : ICarSpecificationService
    {
        public readonly AutoHouseContext _autoHouseContext;
        public CarSpecificationService(AutoHouseContext autoHouseContext)
        {
            _autoHouseContext = autoHouseContext;
        }

        public bool Delite(int id)
        {
            CarSpecification? carSpecifications = _autoHouseContext.CarSpecifications.FirstOrDefault(x => x.Id == id);
            if (carSpecifications == null)
            {
                return false;
            }
            _autoHouseContext.Remove(carSpecifications);
            _autoHouseContext.SaveChanges();
            return true;
        }

        public List<CarSpecification> GetModels()
        {
            List<CarSpecification> carSpecifications = _autoHouseContext.CarSpecifications.ToList();
            return carSpecifications;
        }
        public bool Update(int id, CarSpecificationViewModel model)
        {
            CarSpecification? carSpecifications = _autoHouseContext.CarSpecifications.FirstOrDefault(x => x.Id == id);

            if (carSpecifications == null)
            {
                return false;
            }
            carSpecifications.EngineSize = model.EngineSize;
            carSpecifications.HoursePower = model.HoursePower;
            
            _autoHouseContext.SaveChanges();
            return true;

        }
    }
}
