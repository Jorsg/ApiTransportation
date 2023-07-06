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
    public class CustomerBySaleAgentController : ControllerBase
    {
        private readonly ICustomerBySaleAgent _IcustomerBySaleAgent;

        public CustomerBySaleAgentController(ICustomerBySaleAgent customerBySaleAgent)
        {
            _IcustomerBySaleAgent = customerBySaleAgent;
        }

        [HttpGet]
        public IActionResult GetCustomersbySaleAgents()
        {
            var result = _IcustomerBySaleAgent.GetCustomersbySaleAgents();
            return Ok(result);
        }

        [HttpGet("customersales/{code}")]
        public IActionResult GetCustomersbySaleAgents(string code)
        {
            var result = _IcustomerBySaleAgent.GetCustomersbySaleAgents(code);
            return Ok(result);
        }

        [HttpGet("salesrep/{code}")]
        public IActionResult GetCustomersbySaleAgentsCode(string code)
        {
            var result = _IcustomerBySaleAgent.GetCustomersbySaleAgentsCode(code);
            return Ok(result);
        }
    }
}
