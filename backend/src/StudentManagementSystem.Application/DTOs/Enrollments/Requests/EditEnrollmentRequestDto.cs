namespace StudentManagementSystem.Application.DTOs.Enrollments.Requests
{
    public class EditEnrollmentRequestDto
    {
        public Guid EnrollmentId { get; set; }

        public double Grade { get; set; }
    }
}