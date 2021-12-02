using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Wade_TechTalk.Stardog.Services;
using static Wade_TechTalk.Stardog.Services.TaxonomyService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaxonomyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxonomyController : ControllerBase
    {
        private readonly TaxonomyService _service;
        public TaxonomyController(TaxonomyService service)
        {
            _service = service;
        }
        // GET: api/<TaxonomyController>
        [HttpGet]
        public ActionResult<List<Node>> Get()
        {
            return Ok(_service.GetNodes());
        }

    }
}
