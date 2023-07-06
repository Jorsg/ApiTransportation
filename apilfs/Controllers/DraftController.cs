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
    public class DraftController : ControllerBase
    {
        private readonly IDraftServices _draft;
        private readonly IVDraftsAll _draftAll;

        public DraftController(IDraftServices draft, IVDraftsAll draftsAll)
        {
            _draft = draft;
            _draftAll = draftsAll;
        }

        [HttpGet]
        public IActionResult GetDraft()
        {
            var result = _draft.GetDraft();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetDraft(int id)
        {
            var result = _draft.GetDraft(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post(DTO.Draft.DraftDto draft)
        {
            var result = _draft.InsertDraft(draft);
            if (result > 0)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpPost("UpdateDraft")]
        public IActionResult PostUpdate(DTO.Draft.DraftDto draft)
        {
            var result = _draft.UpdateDraft(draft);
            if (result)
                return Ok(result);
            else
                return BadRequest();
        }

        [HttpGet("DrafAlltbyId/{id}")]
        public IActionResult GetDraftAllbyId(int id)
        {
            var result = _draftAll.GetDraftsAll(id);
            if (result is null)
                return BadRequest();

            return Ok(result);

        }


    }
}
