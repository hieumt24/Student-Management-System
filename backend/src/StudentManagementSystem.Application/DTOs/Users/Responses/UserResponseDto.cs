using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Users.Responses
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? JoinedDate { get; set; }

        public GenderType Gender { get; set; }

        public string? StudentCode { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public RoleType Role { get; set; }

        public LocationType Location { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset LastModifiedOn { get; set; }
    }
}