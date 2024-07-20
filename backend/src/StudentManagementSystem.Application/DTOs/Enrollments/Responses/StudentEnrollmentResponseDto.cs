using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Enrollments.Responses
{
    public class StudentEnrollmentResponseDto
    {
        public Guid Id { get; set; }
        public string CourseCode { get; set; }

        public string CourseName { get; set; }

        public CourseLevelType Level { get; set; }

        public int Credits { get; set; }
        public string SemesterCode { get; set; }

        public double? Grade { get; set; }

        public bool? IsPassed { get; set; }

        public EnrolmentStateType State { get; set; }
    }
}