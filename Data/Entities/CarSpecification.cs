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
        public string EngineSize { get; set; }
        public int HoursePower { get; set; }    
    }
}
