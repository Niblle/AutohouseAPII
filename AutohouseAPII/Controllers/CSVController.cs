using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Reflection;

namespace AutohouseAPII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSVController : ControllerBase
    {
        public readonly ICSVService _cSVService;
        public CSVController(ICSVService cSVService)
        {
           _cSVService = cSVService;
        }
        
        [HttpGet]
        public Task  ReadData()
        {
            
            var dir = Assembly.GetExecutingAssembly().Location;

            var filepath = Path.GetDirectoryName(dir);
            var fullDir = Path.Combine(filepath, "Car_sales.csv");
            return _cSVService.DataFilling(_cSVService.ReadTradesFromFile(fullDir));          
        }
    }
}
