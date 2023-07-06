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
    public class CustomerReceivableController : ControllerBase
    {
        private readonly IVCustomerReceivable _customerReceivable;

        public CustomerReceivableController(IVCustomerReceivable customerReceivable)
        {
            _customerReceivable = customerReceivable;
        }


        [HttpGet("{cardCode}")]
        public IActionResult GetCustomerReceivable(string cardCode)
        {
            var result = _customerReceivable.GetCustomerReceivables(cardCode);
            if (result != null)
                return Ok(result);
            else

                return BadRequest();
        }
    }
}
