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

        Task<(IEnumerable<Enrollment> Data, int TotalRecords)> GetAllEnrollments(PaginationFilter? pagination, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending);

        Task<int> CountStudentInCourse(Guid courseId);

        Task<bool> CheckUserExsitingInEnrollment(Guid courseId, Guid studentId);

        Task<Enrollment> GetStudentInEnrollment(Guid studentId);

        Task<List<Enrollment>> GetReportStudentInEnrollment(Guid studentId);
    }
}