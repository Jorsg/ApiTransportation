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
    public class CustomerRepController : ControllerBase
    {
        private readonly ICustomerRep _customerRep;

        public CustomerRepController(ICustomerRep customerRep)
        {
            _customerRep = customerRep;
        }

        [HttpGet("{codCard}")]
        public IActionResult GetCustomerRep(string codCard)
        {
            var result = _customerRep.GetCustomersRepbyId(codCard);
            if (result is null)
                return BadRequest();

            return Ok(result);
        }

            
    }
}
