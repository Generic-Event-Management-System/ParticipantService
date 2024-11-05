using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParticipantService.Models.Dto;
using ParticipantService.Services.Contracts;

namespace ParticipantService.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantsService _participantsService;

        public ParticipantsController(IParticipantsService participantsService)
        {
            _participantsService = participantsService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateParticipant(ParticipantDto participantDto)
        {
            return Ok( await _participantsService.CreateParticipant(participantDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetParticipants()
        {
            return Ok( await _participantsService.GetParticipants());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetParticipant(int id)
        {
            return Ok( await _participantsService.GetParticipant(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateParticipant(int id, ParticipantDto participantDto)
        {
            return Ok( await _participantsService.UpdateParticipant(id,participantDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParticipant(int id)
        {
            await _participantsService.DeleteParticipant(id);

            return NoContent();
        }

        [HttpPost("validate")]
        public async Task<IActionResult> ValidateParticipants([FromBody] ICollection<int> participantIds)
        {
            return Ok( await _participantsService.CheckParticipantsExists(participantIds));
        }
    }
}
