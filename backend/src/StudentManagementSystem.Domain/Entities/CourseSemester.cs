namespace StudentManagementSystem.Domain.Entities
{
    public class CourseSemester
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }
        public Guid SemesterId { get; set; }
        public Semester Semester { get; set; }
    }
}