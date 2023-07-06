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
    public class CitiesController : ControllerBase
    {
        private readonly ICities _cities;

        public CitiesController(ICities cities)
        {
            _cities = cities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCities()
        {
            var result = _cities.GetCities().Take(80);
            if (result != null)
               return Ok(result);
            else
              return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{name}")]
        public IActionResult GetCities(string name)
        {
            var result = _cities.GetCities(name);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostCities(Models.City city)
        {
            _cities.InsertCities(city);
            _cities.Save();
            return Ok();
        }
    }
}
