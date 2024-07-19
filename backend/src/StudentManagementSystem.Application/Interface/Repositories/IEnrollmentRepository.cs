using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface IEnrollmentRepository : IGenericRepository<Enrollment>
    {
        Task<List<Enrollment>> GetCourseById(Guid courseId);

        Task<bool> CheckStudentPassCourse(Guid enrollmentId, double grade);

        Task<(IEnumerable<Enrollment> Data, int TotalRecords)> GetAllEnrollmentOfStudent(PaginationFilter? pagination, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending);
    }
}