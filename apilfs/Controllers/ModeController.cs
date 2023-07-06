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
    public class ModeController : ControllerBase
    {
        private readonly IMode _mode;

        public ModeController(IMode mode)
        {
            _mode = mode;
        }

        [HttpGet]
        public IActionResult GetMode()
        {
            var result = _mode.GetModes();
            return Ok(result);
        }

        [HttpGet("{modeGroup}")]
        public IActionResult GetMode(string modeGroup)
        {
            var result = _mode.GetModes(modeGroup);
            return Ok(result);
        }

        [HttpGet("modebyServiceLevelSaas/{serviceLevelSaas}")]
        public IActionResult GetModebyServiceLevelSaas(string serviceLevelSaas)
        {
            var result = _mode.GetModebyServiceLevelSaas(serviceLevelSaas);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("modebyServiceLevelYat/{serviceLevelYat}")]
        public IActionResult GetModebyServiceLevelYat(string serviceLevelYat)
        {
            var result = _mode.GetModebyServiceLevelYat(serviceLevelYat);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }


    }
}
