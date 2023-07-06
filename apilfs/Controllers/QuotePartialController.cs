using apilfs.Servicios.Interfaces;
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
    public class QuotePartialController : ControllerBase
    {
        private readonly IQuotePartialServices _quotePartial;

        public QuotePartialController(IQuotePartialServices quotePartial)
        {
            _quotePartial = quotePartial;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostQueotePartialServices(DTO.QuotesDto quote)
        {
            var result = _quotePartial.InsertQuotesAll(quote);
            if (result < 0)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult GetQuotebyId(int id)
        {
            var result = _quotePartial.GetQuotes(id);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }
    }
}
