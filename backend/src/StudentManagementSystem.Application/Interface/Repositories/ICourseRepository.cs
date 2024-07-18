using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<(IEnumerable<Course> Data, int TotalRecords)> GetAllMatchingCourse(PaginationFilter? pagination, Guid semesterId, string? search, string? orderBy, bool? isDescending);
    }
}