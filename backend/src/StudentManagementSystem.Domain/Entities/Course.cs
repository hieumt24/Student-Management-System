using StudentManagementSystem.Domain.Common;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }

        public int Credits { get; set; }

        public int Level { get; set; }
        public int MaxStudent { get; set; }

        public CourseStateType CourseState { get; set; }
        public Guid SemesterId { get; set; }

        public Semester Semester { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}