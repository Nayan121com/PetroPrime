using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Customer customerInfo)
        {
            _customerService.Register(customerInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public Customer Login([FromBody] Login para)
        {
            Customer customer = _customerService.Login(para);
            
                return customer;
            
           
        }
    }
}
