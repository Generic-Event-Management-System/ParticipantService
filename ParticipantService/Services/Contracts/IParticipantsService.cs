using ParticipantService.Models.Dto;
using ParticipantService.Models.Entities;

namespace ParticipantService.Services.Contracts
{
    public interface IParticipantsService
    {
        Task<Participant> CreateParticipant(ParticipantDto participantDto);
        Task<IEnumerable<Participant>> GetParticipants();
    }
}
