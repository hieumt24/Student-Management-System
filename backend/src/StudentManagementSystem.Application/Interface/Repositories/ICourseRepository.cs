using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<(IEnumerable<Course> Data, int TotalRecords)> GetAllMatchingCourse(PaginationFilter? pagination, CourseLevelType? courseLevel, CourseStateType? courseState, string? search, string? orderBy, bool? isDescending);
    }
}