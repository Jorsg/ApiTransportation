using apilfs.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerBillingController : ControllerBase
    {
        private readonly IVCustomerBilling _customerBilling;

        public CustomerBillingController(IVCustomerBilling customerBilling)
        {
            _customerBilling = customerBilling;
        }

        [HttpGet("{customerCode}")]
        public IActionResult GetCustomerBilling(string customerCode)
        {
            var result = _customerBilling.GetCustomerBillings(customerCode);
            if (result != null)
                return Ok(result);

            return BadRequest();
        }
    }
}
