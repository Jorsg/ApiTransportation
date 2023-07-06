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
    public class TypeTruckController : ControllerBase
    {
        private readonly ITypeTruck _typeTruck;

        public TypeTruckController(ITypeTruck typeTruck)
        {
            _typeTruck = typeTruck;
        }

        [HttpGet]
        public IActionResult GetTypeTruck()
        {
            var result = _typeTruck.GetTypeTrucks();
            if (result != null)
                return Ok(result);
            else 
                return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetTypeTruck(int id)
        {
            var result = _typeTruck.GetTypeTrucks(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }
    }
}
