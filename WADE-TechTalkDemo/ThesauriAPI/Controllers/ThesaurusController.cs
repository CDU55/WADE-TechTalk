using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wade_TechTalk.Stardog.Models;
using Wade_TechTalk.Stardog.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThesauriAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThesaurusController : ControllerBase
    {
        private readonly ThesauriService _service;
        public ThesaurusController(ThesauriService service)
        {
            _service = service;
        }
        // GET: api/<ThesaurusController>
        [HttpGet]
        public ActionResult<List<Concept>> Get()
        {
            return _service.GetAll();
        }

        // GET api/<ThesaurusController>/5
        [HttpGet("GetDetails")]
        public ActionResult<Concept> GetDetails([FromBody] string uri)
        {
            return Ok(_service.GetDetailed(uri));
        }

        [HttpGet("GetMatching")]
        public ActionResult<List<Concept>> GetMatching(string pattern)
        {
            return _service.GetAll();
        }
    }
}
