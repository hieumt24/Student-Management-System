using FluentValidation;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;

namespace StudentManagementSystem.Application.Validations.Semesters
{
    public class AddSemesterRequestValidation : AbstractValidator<AddSemesterRequestDto>
    {
        public AddSemesterRequestValidation()
        {
            RuleFor(x => x.SemesterName)
                .NotEmpty().WithMessage("Semester name is required")
                .MinimumLength(4).WithMessage("Semester name can not be less than 4 characters")
                .MaximumLength(50).WithMessage("Semester name can not exceed 50 characters");

            RuleFor(x => x.AcademicYear)
                .NotEmpty().WithMessage("Academic year is required")
                .MinimumLength(4).WithMessage("Academic year can not be less than 4 characters")
                .MaximumLength(50).WithMessage("Academic year can not exceed 50 characters");
        }
    }
}