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
    public class VConfigInsuranceController : ControllerBase
    {
        private readonly IV_ConfigInsurance _fnConfigInsurance;

        public VConfigInsuranceController(IV_ConfigInsurance fnConfigInsurance)
        {
            _fnConfigInsurance = fnConfigInsurance;
        }

        [HttpGet("{customerCode}/{modeGroup}/{from}/{to}")]
        public IActionResult GetFnConfigInsurance(string customerCode, string modeGroup, string from, string to)
        {
            var result = _fnConfigInsurance.GetVConfigInsurances(customerCode, modeGroup, from, to);
            return Ok(result);
        }
    }
}
