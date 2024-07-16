using StudentManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Application.DTOs.Users.Requests
{
    public class AddUserRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }

        public GenderType Gender { get; set; }

        public RoleType Role { get; set; } = RoleType.Student;

        public LocationType Location { get; set; }
    }
}