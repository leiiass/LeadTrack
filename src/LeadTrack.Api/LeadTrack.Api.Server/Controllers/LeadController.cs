using LeadTrack.Services.services;
using Microsoft.AspNetCore.Mvc;

namespace LeadTrack.Api.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly LeadService _leadService;
        public LeadController(LeadService leadService)
        {
            _leadService = leadService;
        }

        [HttpGet]
        public OkObjectResult GetLeads()
        {
            return Ok("");
        }

        [HttpPatch]
        public NoContentResult UpdateLeads()
        {
            return NoContent();
        }
    }
}
