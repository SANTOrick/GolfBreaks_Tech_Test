using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using backend.Services;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {  
        readonly IAdsService _service;

        public AdsController(IAdsService service){
            _service = service;
        }

        [HttpGet]
        public AdResponse Get()
        {
          return _service.GetAds();
        }

    }
}