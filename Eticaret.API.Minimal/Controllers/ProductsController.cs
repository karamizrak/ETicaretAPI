using ETicaret.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.API.Minimal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        private readonly IProductService _productService;

        public Products(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var ss = "";

            return Ok();
        }

        [HttpGet("Products2")]
        public IActionResult GetProducts2()
        {
            return Ok(_productService.GetAllProducts());
        }
    }
}