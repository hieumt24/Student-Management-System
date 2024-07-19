using FluentValidation;
using StudentManagementSystem.Application.DTOs.Users.Requests;

namespace StudentManagementSystem.Application.Validations.Users
{
    public class AddStudentEnrollmentRequestValidation : AbstractValidator<AddStudentEnrollmentRequestDto>
    {
        public AddStudentEnrollmentRequestValidation()
        {
            RuleFor(x => x.StudentId).NotEmpty().WithMessage("StudentId is required");
            RuleFor(x => x.CourseId).NotEmpty().WithMessage("CourseId is required");
            RuleFor(x => x.Location).NotEmpty().WithMessage("Location is required");
        }
    }
}