using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Model:BaseClass
    {
        public string Name { get; set; }
        public string VehicleType { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int CarSpecificationId { get; set; }
        public CarSpecification CarSpecification { get; set; }


    }
}
