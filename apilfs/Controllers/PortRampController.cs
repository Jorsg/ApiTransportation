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
    public class PortRampController : ControllerBase
    {
        private readonly IPort _iport;

        public PortRampController(IPort port)
        {
            _iport = port;
        }

        [HttpGet]
        public IActionResult GetPort()
        {
            var result = _iport.GetPort();
            return Ok(result);
        }

        [HttpGet("{codePort}")]       
        public IActionResult GetPort(string codePort)
        {
            var result = _iport.GetPort(codePort);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddPortRamp(Models.PortsRamp portsRamp)
        {
            try
            {
                _iport.InsertPort(portsRamp);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }


    }
}
