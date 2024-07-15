using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Domain.Entities
{
    public class Enrollment : BaseEntity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }

        public int Grade { get; set; }

        public User Student { get; set; }
        public Course Course { get; set; }
    }
}