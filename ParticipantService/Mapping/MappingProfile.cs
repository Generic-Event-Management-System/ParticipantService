using AutoMapper;
using ParticipantService.Models.Dto;
using ParticipantService.Models.Entities;

namespace ParticipantService.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Participant, ParticipantDto>();
            CreateMap<ParticipantDto, Participant>();
        }
    }
}
