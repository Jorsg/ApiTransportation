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
    public class CustomerStatusInformeController : ControllerBase
    {
        private readonly IVCustomerStatus _customerStatus;

        public CustomerStatusInformeController(IVCustomerStatus customerStatus)
        {
            _customerStatus = customerStatus;
        }

        [HttpGet("{customerCode}")]
        public IActionResult GetFnConfigInsurance(string customerCode)
        {
            var result = _customerStatus.GetVCustomer(customerCode);
            return Ok(result);
        }
    }
}
