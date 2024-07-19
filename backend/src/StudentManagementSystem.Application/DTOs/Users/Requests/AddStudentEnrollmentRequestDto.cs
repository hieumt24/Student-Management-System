using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Users.Requests
{
    public class AddStudentEnrollmentRequestDto
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public LocationType Location { get; set; }
    }
}