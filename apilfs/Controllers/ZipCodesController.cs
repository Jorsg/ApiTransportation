using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using apilfs.Servicios.Interfaces;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZipCodesController : ControllerBase
    {
       
        private readonly IZipCode _zipCode;

        public ZipCodesController(IZipCode zipCode)
        {
            _zipCode = zipCode;
        }
       
        [HttpGet("{zipcod}")]        
        public IActionResult GetZipCode(string zipcod)
        {
            var result =  _zipCode.GetZipCode(zipcod);             
            return Ok(result);
        }

        [HttpGet("byZipCodeAndCountry/{country}/{zipcode}")]
        public IActionResult GetZipCodeByZipCodeAndCountry(string country, string zipcode)
        {          
            var result = _zipCode.GetZipCodeByZipCodeAndCountry(country, zipcode);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("fullZipCode/{fullZipCode}")]
        public IActionResult GetZipCodeFullName(string fullZipCode)
        {
            var result = _zipCode.GetZipCodeFullName(fullZipCode);
            return Ok(result);
        }

        [HttpGet("location/{city}")]
        public IActionResult GetZipCodeCity(string city)
        {
            var result = _zipCode.GetZipCodeCity(city);
            return Ok(result);
        }

        [HttpGet("city")]
        public IActionResult GetCity()
        {
            var result = _zipCode.GetZipCodeCity().Take(100);
            return Ok(result);
        }
    }
}
