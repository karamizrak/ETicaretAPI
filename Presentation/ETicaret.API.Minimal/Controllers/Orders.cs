using ETicaret.Application.Repositories.Order;
using ETicaret.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eticaret.API.Minimal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Orders : ControllerBase
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;

        public Orders(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }


        // GET: api/<Orders>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Orders>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Orders>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _orderWriteRepository.AddASync(new()
            {
                Address = "Adres", CustomerId = new Guid("d929eec0-94ea-4b46-ad51-d2277521a0e8"),
                Description = "Açıklama"
            });
            _orderWriteRepository.SaveAsync();
        }

        // PUT api/<Orders>/5
        [HttpPut("{id}")]
        public async Task PutAsync(string id, [FromBody] string value)
        {
            var order = await _orderReadRepository.GetByIdAsync(new Guid(id));
            order.Description = "Açıklama2";
            await _orderWriteRepository.SaveAsync();
        }

        // DELETE api/<Orders>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}