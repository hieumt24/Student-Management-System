using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Domain.Entities
{
    public class Semester : BaseEntity
    {
        public string SemesterName { get; set; }
        public string SemesterCode { get; set; }
        public string AcademicYear { get; set; }

        public ICollection<Enrollment>? Enrollment { get; set; }
        public ICollection<StudentSemester>? StudentSemesters { get; set; }
        public ICollection<CourseSemester>? CourseSemesters { get; set; }
    }
}