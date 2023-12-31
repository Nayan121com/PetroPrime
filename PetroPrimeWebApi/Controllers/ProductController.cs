﻿using Microsoft.AspNetCore.Http;
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
        public int AddProduct([FromBody] Product ProductInfo)
        {
            return _productService.AddProduct(ProductInfo);
        }

        [HttpGet("FetchProduct")]
        public Product FetchProduct([FromQuery] int ProductId)
        {
            return _productService.FetchProduct(ProductId);
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult DeleteProduct([FromBody]  int ProductId)
        {
             _productService.DeleteProduct(ProductId);
            return Ok("Product Deleted successfully!!");
        }
    }
}
