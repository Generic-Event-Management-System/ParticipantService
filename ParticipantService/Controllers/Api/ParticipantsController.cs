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
    }
}
