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

        public double Widght { get; set; }
        public double Length { get; set; }
    }
}
