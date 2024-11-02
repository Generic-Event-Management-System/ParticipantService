using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParticipantService.Models.Dto;
using ParticipantService.Models.Entities;
using ParticipantService.Persistence;
using ParticipantService.Services.Contracts;

namespace ParticipantService.Services
{
    public class ParticipantsService : IParticipantsService
    {
        private readonly ParticipantDbContext _dbContext;
        private readonly IMapper _mapper;

        public ParticipantsService(ParticipantDbContext dbContext, IMapper mapper) 
        { 
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Participant> CreateParticipant(ParticipantDto participantDto)
        {
            var participant = _mapper.Map<Participant>(participantDto);

            await _dbContext.Participants.AddAsync(participant);

            await _dbContext.SaveChangesAsync();

            return participant;
        }

        public async Task<IEnumerable<Participant>> GetParticipants()
        {
            return await _dbContext.Participants.ToListAsync();
        }

    }
}
