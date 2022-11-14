using ETicaret.Application.Repositories.Customer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eticaret.API.Minimal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Costumers : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public Costumers(ICustomerWriteRepository customerWriteRepository,
            ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        // GET: api/<Costumers>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Costumers>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Costumers>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _customerWriteRepository.AddRangeASync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Osman" },
                new() { Id = Guid.NewGuid(), Name = "Ömer" },
                new() { Id = Guid.NewGuid(), Name = "Didem" },
                new() { Id = Guid.NewGuid(), Name = "Şerife" }
            });
            _customerWriteRepository.SaveAsync();
        }

        // PUT api/<Costumers>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Costumers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}