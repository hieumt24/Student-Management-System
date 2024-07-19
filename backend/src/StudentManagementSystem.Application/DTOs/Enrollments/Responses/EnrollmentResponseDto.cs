using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Enrollments.Responses
{
    public class EnrollmentResponseDto
    {
        public Guid StudentId { get; set; }

        public string StudentName { get; set; }
        public Guid CourseId { get; set; }

        public string CourseCode { get; set; }

        public Guid SemesterId { get; set; }

        public string SemesterCode { get; set; }

        public double? Grade { get; set; }

        public bool? IsPassed { get; set; }

        public EnrolmentStateType State { get; set; }
        public LocationType Location { get; set; }
    }
}