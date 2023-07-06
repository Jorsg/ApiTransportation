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
    public class AccesorialsDrayageCostsController : ControllerBase
    {
        private readonly IAccessorialsDrayageCost _accesorials;
        public AccesorialsDrayageCostsController(IAccessorialsDrayageCost accesorials)
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
            var result = _accesorials.GetAccessorialsDrayageCosts();
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

    }
}
