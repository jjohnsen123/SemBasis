 using lek09opgaver.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lek09opgaver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        private static List<Person> persons = new List<Person>
        {
            new Person { Id = 1, Name = "Anders", Age = 30 },
            new Person { Id = 2, Name = "Birgitte", Age = 25 },
            new Person { Id = 3, Name = "Carsten", Age = 40 }
        };

        [HttpGet]
        public ActionResult<List<Person>> GetPersons()
        {
            return persons;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> GetPerson(int id)
        {
            var person = persons.FirstOrDefault(p => p.Id == id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }

        [HttpPost]
        public ActionResult<Person> AddPerson([FromBody] Person p)
        {
            if (p == null)
            {
                return BadRequest("Person data is null");
            }

            if (persons.Any())
            {
                p.Id = persons.Max(p => p.Id) + 1;
            }
            else
            {
                p.Id = 1;
            }
            persons.Add(p);

            _logger.LogInformation($"Person added: {p.Name}, Id: {p.Id}");

            return CreatedAtAction(nameof(GetPerson), new { Id = p.Id }, p);
        }
    }
}
