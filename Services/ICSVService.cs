using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICSVService
    {
        public List<AutoHouseModel> ReadTradesFromFile(string filename);
        public Task DataFilling(List<AutoHouseModel> autoHouseModels);
    }
}
