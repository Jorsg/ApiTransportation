using apilfs.DTO;
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
    public class MexicoRateController : ControllerBase
    {
        private readonly IMexicoRate _mexicoRate;


        public MexicoRateController(IMexicoRate mexicoRate)
        {
            _mexicoRate = mexicoRate;
        }

        [HttpGet]
        public IActionResult GetTxMexico()
        {
            var result = _mexicoRate.GetMexicoRate();
            return Ok(result);
        }

        [HttpPost("MexicoRates")]
        public IActionResult GetTarifasMexico(RequestBodyMexicoRatesDto body)
        {
            var result = _mexicoRate.GetMexicoRate(body.FromZipCode, body.ToZipCode, body.FromCountry, body.ToCountry, body.IdTypeTruck);
            return Ok(result);
        }
    }
}
