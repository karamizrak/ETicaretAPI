
using ETicaret.Application.Repositories.Product;
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
           var ss= await _productWriteRepository.SaveAsync();
            return Ok();
        }

        
    }
}