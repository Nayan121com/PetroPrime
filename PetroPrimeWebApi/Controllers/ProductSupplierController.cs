using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSupplierController : ControllerBase
    {
        private ProductSupplierService _productSupplierService;

        public ProductSupplierController(ProductSupplierService productSupplierService)
        {
            _productSupplierService = productSupplierService;
        }

        [HttpPost("AddProductSupplier")]
        public IActionResult AddProductSupplier([FromBody] ProductSupplier para)
        {
            _productSupplierService.AddProductSupplier(para);
            return Ok("Product supplier added successfully!");
        }
        [HttpGet("FetchProductSupplier")]
        public List<int> FetchProductSupplier([FromQuery] int productId)
        {
            return _productSupplierService.FetchProductSupplier(productId);
        }
    }
}
