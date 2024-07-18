using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Domain.Entities
{
    public class StudentSemester : BaseEntity
    {
        public Guid StudentId { get; set; }
        public User Student { get; set; }

        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}