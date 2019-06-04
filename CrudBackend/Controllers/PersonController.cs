using CrudBackend.Data;
using CrudBackend.Models;
using CrudBackend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // GET: api/Person
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personRepository.GetAll());
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_personRepository.Get(id));
        }

        // POST: api/Person
        [HttpPost]
        public IActionResult Post([FromBody] AddPersonModel model)
        {
            _personRepository.Add(model);
            return StatusCode(StatusCodes.Status201Created);
        }        

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Person person = _personRepository.Get(id);
            _personRepository.Delete(person);
            return NoContent();
        }
    }
}
