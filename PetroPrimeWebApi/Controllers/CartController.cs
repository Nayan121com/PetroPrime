using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private CartService _cartService;

        public CartController(CartService cartService)
        {
                _cartService = cartService;
        }

        [HttpPost("AddToCart")]
        public IActionResult AddToCart([FromBody] Cart cartInfo)
        {
            _cartService.AddToCart(cartInfo);
            return Ok("Cart Created successfully");
        }

        [HttpPut("ClearCart")]
        public IActionResult ClearCart([FromBody] int customerId)
        {
            _cartService.clearCart(customerId);
            return Ok("Cart Cleared!");
        }
    }
}
