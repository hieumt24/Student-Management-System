using StudentManagementSystem.Domain.Common;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Users.Responses
{
    public class UserDto : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? JoinedDate { get; set; }

        public string? StudentCode { get; set; }

        public string UserName { get; set; } = string.Empty;

        public RoleType Role { get; set; }

        public LocationType Location { get; set; }
    }
}