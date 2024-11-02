namespace ParticipantService.Models.Dto
{
    public class ParticipantDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required bool IsActive { get; set; } = false;
    }
}