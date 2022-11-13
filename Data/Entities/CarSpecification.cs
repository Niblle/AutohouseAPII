using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CarSpecification:BaseClass
    {
       
        public Model Model { get;set;}
        public double EngineSize { get; set; }
        public int HoursePower { get; set; }    
    }
}
