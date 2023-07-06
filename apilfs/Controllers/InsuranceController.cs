using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IInsurance _insurance;

        public InsuranceController(IInsurance insurance)
        {
            _insurance = insurance;
        }

        [HttpGet]
        public IActionResult GetInsurance()
        {
            var result = _insurance.GetInsurances();
            return Ok(result);
        }

        [HttpGet("{mode}")]
        public IActionResult GetInsuranceMode(int mode)
        {
            var result = _insurance.GetInsurancesMode(mode);
            return Ok(result);
        }

    }
}
