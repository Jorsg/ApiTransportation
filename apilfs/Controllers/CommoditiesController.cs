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
    public class CommoditiesController : ControllerBase
    {
        private readonly ICommodities _icommodities;

        public CommoditiesController(ICommodities commodities)
        {
            _icommodities = commodities;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCommodities()
        {
            var result = _icommodities.GetCommodities();
            return Ok(result);
        }

        /// <summary>
        /// Code es un parametro string que ingresa el usuario para consultar los commodities codeNameCommodities = 1, 
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Retorna el commoditie consultado por ese código ingresado</returns>
        [HttpGet("{code}")]
        public IActionResult GetCommodities(string code)
        {
            var result = _icommodities.GetCommodities(code);
            return Ok(result);
        }

        //[HttpGet("{name}")]
        //public IActionResult GetCommodiName(string name)
        //{
        //    var result = _icommodities.GetCommoditiesName(name);
        //    return Ok(result);
        //}



    }
}
