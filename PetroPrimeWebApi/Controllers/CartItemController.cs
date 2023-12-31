﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private CartItemService _cartItemService;
        public CartItemController([FromBody] CartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpPost("AddCartItem")]
        public IActionResult AddCartItem([FromBody] CartItem cartItem)
        {
            _cartItemService.AddCartItem(cartItem);
            return Ok("Item Added Successfully");

        }
        [HttpPut("UpdateCartItem")]
        public IActionResult UpdateCartItem([FromBody] CartItemInfo para)
        {
            _cartItemService.UpdateCartItem(para);
            return Ok("Item Updated in cart");
        }
        [HttpDelete("DeleteCartItem")]
        public IActionResult DeleteCartItem([FromBody] int cartItemId)
        {
            _cartItemService.DeleteCartItem(cartItemId);
            return Ok("Item Deleted from cart");
        }
    }
}
