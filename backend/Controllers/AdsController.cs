using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            string currentPath = Directory.GetCurrentDirectory();

            currentPath = currentPath +"\\response.json";

            string jsonMe = System.IO.File.ReadAllText(@currentPath);
        
            return jsonMe;
        }

    }
}