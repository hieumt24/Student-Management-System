using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.DTOs.Courses.Requests
{
    public class AddCourseRequestDto
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }

        public int Level { get; set; }
        public int Credits { get; set; }

        public int MaxStudent { get; set; }
        public CourseStateType CourseState { get; set; }
        public Guid SemesterId { get; set; }
    }
}