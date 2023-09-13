using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetroPrime.BAL.Services;
using PetroPrime.Entity.Model;

namespace PetroPrimeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private SupplierService _supplierService;

        public SupplierController(SupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Supplier supplierInfo)
        {
            _supplierService.Register(supplierInfo);
            return Ok("Register successfully!!");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] Supplier supplierInfo)
        {
            Supplier customer = _supplierService.Login(supplierInfo);
            if (customer != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
    }
}
