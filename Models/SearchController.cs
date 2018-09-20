using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SafariVacationApiEndorsed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SearchController : ControllerBase
    {
        [HttpGet]
        public ActionResult<SeenAnimal> Get([FromQuery] string species)
        {
            var db = new SafariVacationApiEndorsedContext();
            var animal = db.SeenAnimals.Where(w => w.Species == species).First();
            return animal;
        }

    }
    
}

