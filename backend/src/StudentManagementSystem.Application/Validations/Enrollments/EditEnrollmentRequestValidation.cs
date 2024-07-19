using FluentValidation;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;

namespace StudentManagementSystem.Application.Validations.Enrollments
{
    public class EditEnrollmentRequestValidation : AbstractValidator<EditEnrollmentRequestDto>
    {
        public EditEnrollmentRequestValidation()
        {
            RuleFor(x => x.EnrollmentId)
                .NotEmpty().WithMessage("Enrollment Id is required");

            RuleFor(x => x.Grade)
                .NotEmpty().WithMessage("Grade is required")
                .InclusiveBetween(0, 10.00).WithMessage("Grade must be between 0 and 10.00");
        }
    }
}