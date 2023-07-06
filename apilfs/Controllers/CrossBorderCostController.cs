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
    public class CrossBorderCostController : ControllerBase
    {
        private readonly ICrossBorderCost _crossBorderCost;

        public CrossBorderCostController(ICrossBorderCost crossBorderCost)
        {
            _crossBorderCost = crossBorderCost;
        }

        [HttpGet("crossBorderCostByTypeTruck/{IdTypeTruck}")]
        public IActionResult GetCrosBorderCostByTypeTruck(int IdTypeTruck)
        {
            var result = _crossBorderCost.GetCrosBorderCostByTypeTruck(IdTypeTruck);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }



    }
}
