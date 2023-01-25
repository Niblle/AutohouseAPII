using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.CarSpecifications
{
    public interface ICarSpecificationService
    {

        public bool Delite(int id);
        public List<CarSpecification> GetModels();
        public bool Update(int id, CarSpecificationViewModel model);
    }
}
