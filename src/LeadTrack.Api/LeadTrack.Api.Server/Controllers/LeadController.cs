using LeadTrack.Domain.models;
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
            var leads = _leadService.GetAll();
            return Ok(leads);
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateLead(int id, [FromBody] StatusEnum status)
        {
            try
            {
                _leadService.UpdateLead(id, status);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/download")]
        public IActionResult DownloadLeadFile(int id)
        {
            try
            {
                var fileBytes = _leadService.GenerateLeadFile(id);
                return File(fileBytes, "text/plain", $"Lead_{id}_Accepted.txt");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
