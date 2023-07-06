using apilfs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using apilfs.Repository.Interfaces;
using apilfs.DTO;
using Microsoft.Extensions.Logging;
using apilfs.Servicios.Interfaces;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        
        private readonly IQuotesServices _quoteServices;
        private readonly IQuotePartialServices _quotePartial;
        private readonly IQuoteIncServices _quoteInc;
        private readonly IQuoteLtlServices _quoteLtl;
        private readonly IQuoteDrayageServices _quoteDrayage;
        private readonly IQuoteHistory _quoteHistory;

        public QuoteController(IQuotesServices quoteServices, IQuotePartialServices quotePartial, IQuoteIncServices quoteInc, IQuoteDrayageServices quoteDrayage,
                               IQuoteLtlServices quoteLtl, IQuoteHistory quoteHistory)
        {
            _quoteServices = quoteServices;
            _quotePartial = quotePartial;
            _quoteDrayage = quoteDrayage;
            _quoteInc = quoteInc;
            _quoteLtl = quoteLtl;
            _quoteHistory = quoteHistory;
        }

        [HttpGet("QuoteHistory/{idCustomer}")]
        public IActionResult GetQuoteServices(int idCustomer)
        {
            
            var result = _quoteHistory.GetQuoteHistory(idCustomer);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost("SaveQuoteFTL")]
        public IActionResult PostQuoteFTLServices(DTO.QuotesDto quote)
        {            
            var resul =  _quoteServices.InsertQuotesAll(quote);
            
            if (resul > 0)
                return Ok(resul);
            else
             return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost("SaveQuoteFTLMex")]
        public IActionResult PostQuoteFTLMexServices(DTO.QuotesDto quote)
        {
            var resul =  _quoteServices.InsertQuotesAll(quote);            
            if (resul > 0)
                return Ok(resul);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost("SaveQuotePartial")]
        public IActionResult PostQueotePartialServices(DTO.QuotesDto quote)
        {
            var result = _quotePartial.InsertQuotesAll(quote);
            if (result > 0)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost("SaveQuoteLTL")]
        public IActionResult PostQueoteLTLServices(DTO.QuotesDto quote)
        {
            var result = _quoteLtl.InsertQuotesLtl(quote);
            if (result > 0)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost("SaveQuoteINC")]
        public IActionResult PostQueoteINCServices(DTO.QuotesDto quote)
        {
            var result = _quoteInc.InsertQuotesInc(quote);
            if (result > 0)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="quote"></param>
        /// <returns></returns>
        [HttpPost("SaveQuoteDrayage")]
        public IActionResult PostQueoteDrayageServices(DTO.QuotesDto quote)
        {
            var result =  _quoteDrayage.InsertQuotesDrayage(quote);            
            if (result > 0)
                return Ok(result);
            else
                return BadRequest();
        }


        [HttpPost("UpdateQuotePartial")]
        public IActionResult PostUpdateQueotePartialServices(DTO.Quote.UpdateQuote quote)
        {
            var result = _quotePartial.UpdateQuotesAll(quote);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost("UpdateQuoteDrayage")]
        public IActionResult PostUpdateQueoteDrayageServices(DTO.Quote.UpdateQuote quote)
        {
            var result = _quoteDrayage.updatetQuotesDrayage(quote);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost("UpdateQuoteINC")]
        public IActionResult PostUpdateQueoteINCServices(DTO.Quote.UpdateQuote quote)
        {
            var result = _quoteInc.UpdatetQuotesInc(quote);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost("UpdateQuoteLTL")]
        public IActionResult PostUpdateQueoteLTLServices(DTO.Quote.UpdateQuote quote)
        {
            var result = _quoteLtl.UpdateQuotesLtl(quote);
            if (result)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost("UpdateQuoteFTLMex")]
        public IActionResult PostUpdateQuoteFTLMexServices(DTO.Quote.UpdateQuote quote)
        {
            var resul = _quoteServices.UpdatetQuotesAll(quote);
            if (resul)
                return Ok();
            else
                return BadRequest();
        }

        [HttpPost("UpdateQuoteFTL")]
        public IActionResult PostUpdateQuoteFTLServices(DTO.Quote.UpdateQuote quote)
        {
            var resul = _quoteServices.UpdatetQuotesAll(quote);
            if (resul)
                return Ok();
            else
                return BadRequest();
        }


    }
}
