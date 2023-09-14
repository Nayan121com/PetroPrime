using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;

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
        public IActionResult AddProductSupplier(int supplierId, int productId)
        {
            _productSupplierService.AddProductSupplier(supplierId, productId);
            return Ok("Product supplier added successfully!");
        }
        [HttpGet("FetchProductSupplier")]
        public List<int> FetchProductSupplier(int productId)
        {
            return _productSupplierService.FetchProductSupplier(productId);
        }
    }
}
