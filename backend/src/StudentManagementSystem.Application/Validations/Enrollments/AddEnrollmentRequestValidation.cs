using FluentValidation;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;

namespace StudentManagementSystem.Application.Validations.Enrollments
{
    public class AddEnrollmentRequestValidation : AbstractValidator<AddEnrollmentRequestDto>
    {
        public AddEnrollmentRequestValidation()
        {
            RuleFor(x => x.StudentId).NotEmpty().WithMessage("Student id is required");
            RuleFor(x => x.CourseId).NotEmpty().WithMessage("Course id is required");
            RuleFor(x => x.SemesterId).NotEmpty().WithMessage("Semester id is required");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Location is required").IsInEnum();
        }
    }
}