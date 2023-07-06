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
    public class ModeGroupController : ControllerBase
    {
        private readonly IModeGroup _modeGroup;

        public ModeGroupController(IModeGroup modeGroup)
        {
            _modeGroup = modeGroup;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetModeGroups()
        {
            var result = _modeGroup.GetModeGroups();
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modeGroup"></param>
        /// <returns></returns>
        [HttpGet("{modeGroup}")]
        public IActionResult GetModeGroups(string modeGroup)
        {
            var result = _modeGroup.GetModeGroups(modeGroup);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("modeGroupByBusinessUnit/{businessUnit}")]
        public IActionResult GetModeGroupByBusinessUnit(string businessUnit)
        {
            var result = _modeGroup.GetModeGroupByBusinessUnit(businessUnit);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modeGroup"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PostModeGroup(Models.ModeGroup modeGroup)
        {
            _modeGroup.InsertModeGroup(modeGroup);
            _modeGroup.Save();
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modeGroup"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult PutModeGroup(Models.ModeGroup modeGroup)
        {
            _modeGroup.Update(modeGroup);
            _modeGroup.Save();
            return Ok();
        }
    }
}
