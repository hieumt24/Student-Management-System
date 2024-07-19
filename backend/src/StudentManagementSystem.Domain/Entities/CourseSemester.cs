using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Domain.Entities
{
    public class CourseSemester : BaseEntity
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}