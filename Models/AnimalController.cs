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
        public ActionResult<IEnumerable<SeenAnimal>> Get()
        {
            var db = new SafariVacationApiEndorsedContext();
            return db.SeenAnimals;
        }

        [HttpPost]
        public ActionResult<SeenAnimal> Post([FromBody] string species)
        {
            var animal = new SeenAnimal
            {
                Species = species,
                LocationOfLastSeen = "Out There",
            };

            var db = new SafariVacationApiEndorsedContext();

            db.SeenAnimals.Add(animal);
            db.SaveChanges();
            return animal;
        }

    }
    
}

