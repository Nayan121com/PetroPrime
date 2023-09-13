using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product ProductInfo)
        {
            _productService.AddProduct(ProductInfo);
            return Ok("Product Added Successfully");
        }

        //[HttpPost("ProductDetails")]
        //public IActionResult ProductDetails([FromBody] int productId)
        //{
        //    _productService.ProductDetails(productId);
        //    return Ok("Product Details added successfully");
        //}
    }
}
