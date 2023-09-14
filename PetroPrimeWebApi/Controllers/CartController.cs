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
        public int AddToCart([FromBody] Cart cartInfo)
        {
            return _cartService.AddToCart(cartInfo);
            
        }

        [HttpPut("ClearCart")]
        public IActionResult ClearCart([FromBody] int cartId)
        {
            _cartService.clearCart(cartId);
            return Ok("Cart Cleared!");
        }
    }
}
