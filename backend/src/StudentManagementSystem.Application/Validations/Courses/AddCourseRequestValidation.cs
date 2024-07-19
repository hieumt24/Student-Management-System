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
            RuleFor(x => x.Level).NotEmpty().WithMessage("Level is required")
                .GreaterThan(0).WithMessage("Level should be greater than 0")
                .LessThan(10).WithMessage("Level should be less than 10");
            RuleFor(x => x.Credits).NotEmpty().WithMessage("Credits is required").
                GreaterThan(0).WithMessage("Credits should be greater than 0").
                LessThan(15).WithMessage("Credits should be less than 15");
            RuleFor(x => x.MaxStudent).NotEmpty().WithMessage("Max student is required")
                .GreaterThan(0).WithMessage("Student should be greater than 0");

            RuleFor(x => x.SemesterId).NotEmpty().WithMessage("Semester is required");
        }
    }
}