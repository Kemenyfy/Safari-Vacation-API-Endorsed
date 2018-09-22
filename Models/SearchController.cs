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
        private SafariVacationApiEndorsedContext db { get; set; }

        public SearchController()
        {
            this.db = new SafariVacationApiEndorsedContext();
        }

        [HttpGet]
        public ActionResult<SeenAnimal> GetBySpecies([FromQuery] string species, string location)
        {
            if (species != null)
            {
                var animal = this.db.SeenAnimals.Where(w => w.Species == species).First();
                return animal;

                // In Postman Use --> https://localhost:5001/api/search?species=Lion

            }
            else if (location != null)
            {
                var animal = db.SeenAnimals.Where(w => w.LocationOfLastSeen == location).First();
                return animal;

                // In Postman Use --> https://localhost:5001/api/search?species=Lion
            }
            else
            {
                var animal = db.SeenAnimals.Where(w => w.LocationOfLastSeen == location).First();
                return animal;
            }

        }

    }

}
