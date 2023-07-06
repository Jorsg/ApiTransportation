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
    public class SalesAgentController : ControllerBase
    {
        private readonly ISalesAgent _salesAgent;

        public SalesAgentController(ISalesAgent salesAgent)
        {
            _salesAgent = salesAgent;
        }
    }
}
