using StudentManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Application.DTOs.Users.Requests
{
    public class EditUserRequestDto
    {
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        public DateTime? JoinedDate { get; set; }

        [Range(1, 2)]
        public GenderType Gender { get; set; }
    }
}