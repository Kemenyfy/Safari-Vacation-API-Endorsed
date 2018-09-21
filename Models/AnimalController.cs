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
        private SafariVacationApiEndorsedContext db { get; set; }

        public AnimalController()
        {
            this.db = new SafariVacationApiEndorsedContext();
        }

        [HttpGet]
        public ActionResult<IEnumerable<SeenAnimal>> Get()
        {
            var db = new SafariVacationApiEndorsedContext();
            return db.SeenAnimals;

        // In Postman Use --> https://localhost:5001/api/animal

        }

        [HttpPost]
        public ActionResult<SeenAnimal> Post([FromBody] string Species)
        {
            var animal = new SeenAnimal
            {
                Species = Species,
            };

            var db = new SafariVacationApiEndorsedContext();

            db.SeenAnimals.Add(animal);
            db.SaveChanges();
            return animal;

        // In Postman Use --> https://localhost:5001/api/animal/ --> Add Animal Name in Quotes in Body

        }

        [HttpGet("{Location}")]
        public IEnumerable<SeenAnimal> GetByLocation(string location)
        {
            var animal = this.db.SeenAnimals.Where(f => f.LocationOfLastSeen == location);
            return animal;
        
        // In Postman Use --> https://localhost:5001/api/animal/Outside
        // In Postman Use --> %20 if there is a space in the name
        
        }

        [HttpPut("{species}")]
        public ActionResult<SeenAnimal> Add1TimesSeen(string species)
        {
            var animal = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species);
            animal.CountOfTimesSeen = animal.CountOfTimesSeen + 1;
            this.db.SaveChanges();
            return animal;
        
        // In Postman Use --> https://localhost:5001/api/animal/Cat
        
        }
        
        [HttpDelete("{species}")]
        public ActionResult<SeenAnimal> Delete(string species)
        {
            var animal = this.db.SeenAnimals.FirstOrDefault(f => f.Species == species);
            db.SeenAnimals.Remove(animal);
            db.SaveChanges();
            Console.Write($"Removed {animal}");
            return animal;
        
        // In Postman Use --> https://localhost:5001/api/animal/cat
        
        }
    }
}
        
