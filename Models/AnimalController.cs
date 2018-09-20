using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SafariVacationApiEndorsed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new List<string> {"Hello", "World"};
        }

    }
    
}

