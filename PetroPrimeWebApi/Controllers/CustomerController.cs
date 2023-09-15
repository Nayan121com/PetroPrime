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
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(CustomerService customerService, ILogger<CustomerController> logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Customer customerInfo)
        {
            _logger.LogInformation("Seri Log is Working");
            _customerService.Register(customerInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public Customer Login([FromBody] Login para)
        {
            _logger.LogInformation("Customer Logged In!!");
            Customer customer = _customerService.Login(para);
            
                return customer;
        }
    }
}
