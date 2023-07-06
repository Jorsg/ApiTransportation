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
    public class InvoiceController : ControllerBase
    {
        private readonly IVInvoice _invoice;

        public InvoiceController(IVInvoice invoice)
        {
            _invoice = invoice;
        }

        [HttpGet("{invoice}")]
        public IActionResult GetInvoice(string invoice)
        {
            var result = _invoice.GetInvoices(invoice);
            if (result != null)
                return Ok(result);

            return BadRequest();
        }
    }
}
