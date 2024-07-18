using FluentValidation;
using StudentManagementSystem.Application.DTOs.Courses.Requests;

namespace StudentManagementSystem.Application.Validations.Courses
{
    public class AddCourseRequestValidation : AbstractValidator<AddCourseRequestDto>
    {
        public AddCourseRequestValidation()
        {
            RuleFor(x => x.CourseCode).NotEmpty().WithMessage("Course code is required");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.Level).NotEmpty().WithMessage("Level is required").IsInEnum();
            RuleFor(x => x.Credits).NotEmpty().WithMessage("Credits is required").
                GreaterThan(0).WithMessage("Credits should be greater than 0").
                LessThan(15).WithMessage("Credits should be less than 15");
            RuleFor(x => x.MaxStudent).NotEmpty().WithMessage("Max student is required")
                .GreaterThan(0).WithMessage("Student should be greater than 0");
            RuleFor(x => x.CourseState).NotEmpty().WithMessage("Course state is required").IsInEnum();
        }
    }
}