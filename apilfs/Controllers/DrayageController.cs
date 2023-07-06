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
    public class DrayageController : ControllerBase
    {
        private readonly IDrayage _drayage;

        public DrayageController(IDrayage drayage)
        {
            _drayage = drayage;
        }

        [HttpGet]
        public IActionResult GetDrayage()
        {
            var result = _drayage.GetDrayages();
            return Ok(result);
        }

        [HttpGet("{idPort}/{IdCustomers}/{IdVendors}")]
        public IActionResult GetDrayages(int idPort, int IdCustomers, int IdVendors)
        {
            var result = _drayage.GetDrayages(idPort,IdCustomers, IdVendors);
            return Ok(result);
        }
    }
}
