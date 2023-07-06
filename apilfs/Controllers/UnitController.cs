using apilfs.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace apilfs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnit _unit;

        public UnitController(IUnit unit)
        {
            _unit = unit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetUnit()
        {
            var result = _unit.GetUnits();
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostUnit(Models.Unit unit)
        {
            _unit.InsertUnit(unit);           
            return Ok();
        }

    }
}
