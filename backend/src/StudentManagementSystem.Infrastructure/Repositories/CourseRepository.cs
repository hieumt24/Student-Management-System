using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<(IEnumerable<Course> Data, int TotalRecords)> GetAllMatchingCourse(PaginationFilter? pagination, Guid semesterId, string? search, string? orderBy, bool? isDescending)
        {
            throw new NotImplementedException();
        }
    }
}