using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }

        public int Credits { get; set; }

        public int MaxStudent { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}