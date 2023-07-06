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
    public class CongestionNotesController : ControllerBase
    {
        private readonly ICongestionNotes _congestionNotes;

        public CongestionNotesController(ICongestionNotes congestionNotes)
        {
            _congestionNotes = congestionNotes;
        }

        [HttpGet]
        public IActionResult GetCongestionNotes()
        {
            var result = _congestionNotes.GetCongestionNotes();
            return Ok(result);
        }

        [HttpGet("{zipcode}/{country}")]
        public IActionResult GetCongestionNotes(string zipcode, string country)
        {
            var result = _congestionNotes.GetCongestionNoteByZipcode(zipcode, country);
            if (result != null)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpPost]
        public IActionResult AddCongestionNotes(Models.CongestionNote congestionNote)
        {
            try
            {
                _congestionNotes.InsertCongestinNotes(congestionNote);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }        

        }

        [HttpPut]
        public IActionResult Update(Models.CongestionNote congestionNote)
        {
            try
            {
                _congestionNotes.Update(congestionNote);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(Models.CongestionNote congestionNote)
        {
            try
            {
                _congestionNotes.Delete(congestionNote);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }            
        }
    }
}
