using System;
using AnimalAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalAPIContext _db;

        public AnimalsController(AnimalAPIContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(string name, string type, string gender, string behavior, string dateAdded)
        {
            var query = _db.Animals.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }
            if (gender != null)
            {
                query = query.Where(entry => entry.Gender == gender);
            }
            if (behavior != null)
            {
                query = query.Where(entry => entry.Behavior == behavior);
            }
            if (dateAdded != null)
            {
                query = query.Where(entry => entry.DateAdded == dateAdded);
            }
            return query.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal animal)
        {
            animal.AnimalId = id;
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Animal animalToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
            _db.Animals.Remove(animalToDelete);
            _db.SaveChanges();
        }
    }
}
