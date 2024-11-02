﻿namespace ParticipantService.Models.Entities
{
    public class Participant
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required bool IsActive { get; set; } = false;
    }
}
