using Microsoft.EntityFrameworkCore;
using ParticipantService.Models.Entities;

namespace ParticipantService.Persistence
{
    public class ParticipantDbContext : DbContext
    {
        public DbSet<Participant> Participants { get; set; }

        public ParticipantDbContext(DbContextOptions<ParticipantDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
