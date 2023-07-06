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
    public class CountriesController : ControllerBase
    {
        private readonly ICountries _countries;

        public CountriesController(ICountries countries)
        {
            _countries = countries;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCountries()
        {
            var result = _countries.GetCountries();
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        [HttpGet("{code}")]
        public IActionResult GetCountries(string code)
        {
            var result = _countries.GetCountries(code);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("countryByIsoCode/{code}")]
        public IActionResult GetCountryByIsoCode(string code)
        {
            var result = _countries.GetCountryByIsoCode(code);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostCountries(Models.Country country)
        {
            _countries.InsertCountries(country);
            _countries.Save();
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult PutCountries(Models.Country country)
        {
            _countries.Update(country);
            _countries.Save();
            return Ok();
        }


    }
}
