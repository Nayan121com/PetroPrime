using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.DAL.Repository.InterfaceDefination;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("AddOrder")]
        public IActionResult AddOrderDetails([FromBody] Orders OrderInfo)
        {
            _orderService.AddOrderDetails(OrderInfo);
            return Ok("Order Successfull");
        }
    }
}
