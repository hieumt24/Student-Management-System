using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface IEnrollmentRepository : IGenericRepository<Enrollment>
    {
        Task<List<Enrollment>> GetCourseById(Guid courseId);

        Task<bool> CheckStudentPassCourse(Guid enrollmentId, double grade);
    }
}