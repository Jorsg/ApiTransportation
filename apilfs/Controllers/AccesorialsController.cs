using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Repository.Interfaces;
using apilfs.DTO;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccesorialsController : ControllerBase
    {
        private readonly IAccesorials _accesorials;
        public AccesorialsController(IAccesorials accesorials)
        {
            _accesorials = accesorials;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAccesorials()
        {
            var result =   _accesorials.GetAccessorials();
            return Ok(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{name}")]
        public IActionResult GetAccesorials(string name)
        {
            var result = _accesorials.GetAccessorials(name);
            return Ok(result);
        }

        [HttpPost("AccessorialsByIdsOrCodes")]
        public IActionResult GetAccessorialsByIdsOrCodes(RequestBodyAccessorialsDto body)
        {
            var result = _accesorials.GetAccessorialsByIdsOrCodes(body.ids, body.codes);
            return Ok(result);
        }
    }
}
