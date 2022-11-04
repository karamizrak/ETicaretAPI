using System.Net;
using ETicaret.Application.Repositories.Product;
using ETicaret.Application.ViewModel.Products;
using ETicaret.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.API.Minimal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public Products(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_productReadRepository.GetAll(false));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(_productReadRepository.GetByIdAsync(Guid.Parse(id), false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model)
        {
            await _productWriteRepository.AddASync(new Product()
            {
                Name = model.Name,
                Price = model.Price,
                Stock = model.Stock
            });
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product model)
        {
            var product = await _productReadRepository.GetByIdAsync(model.Id);
            product.Name = model.Name;
            product.Price = model.Price;
            product.Stock = model.Stock;
            await _productWriteRepository.SaveAsync();

            return Ok((int)HttpStatusCode.NoContent);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Put(string id)
        {
            await _productWriteRepository.Remove(Guid.Parse(id));
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.OK);
        }

        [HttpGet("Calis")]
        public async Task<IActionResult> GetProducts()
        {
            await _productWriteRepository.AddRangeASync(new()
            {
                new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Kalem1", Price = 12.1, Stock = 10 },
                new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Kalem2", Price = 12.1, Stock = 11 },
                new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Kalem3", Price = 12.1, Stock = 12 },
                new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Kalem4", Price = 12.1, Stock = 13 },
                new() { Id = Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Kalem5", Price = 12.1, Stock = 14 }
            });
            var ss = await _productWriteRepository.SaveAsync();
            return Ok();
        }
    }
}