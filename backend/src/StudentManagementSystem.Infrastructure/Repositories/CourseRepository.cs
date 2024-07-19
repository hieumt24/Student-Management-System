using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;
using System.Linq.Expressions;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CheckCourseFullSlot(Guid courseId)
        {
            var totalCourse = await _dbContext.Enrollments.CountAsync(x => x.CourseId == courseId);
            var course = await _dbContext.Courses.FirstOrDefaultAsync(x => x.Id == courseId);
            if (totalCourse > course.MaxStudent)
            {
                return true;
            }
            return false;
        }

        public async Task<(IEnumerable<Course> Data, int TotalRecords)> GetAllMatchingCourse(PaginationFilter? pagination, CourseLevelType? courseLevel, CourseStateType? courseState, string? search, string? orderBy, bool? isDescending)
        {
            var query = _dbContext.Courses.AsNoTracking();

            if (courseLevel.HasValue)
            {
                query = query.Where(x => x.Level == courseLevel);
            }

            if (courseState.HasValue)
            {
                query = query.Where(x => x.CourseState == courseState);
            }

            string searchPhraseLower = search?.ToLower() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(searchPhraseLower))
            {
                query = query.Where(x => x.Title.ToLower().Contains(searchPhraseLower)
                || x.CourseCode.ToLower().Contains(searchPhraseLower));
            }

            var totalRecords = await query.CountAsync();

            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                var columnsSelector = new Dictionary<string, Expression<Func<Course, object>>>
                {
                    { nameof(Course.CourseCode), x => x.CourseCode },
                    { nameof(Course.Title), x => x.Title },
                    { nameof(Course.Credits), x => x.Credits },
                    { nameof(Course.Level), x => x.Level },
                    { nameof(Course.MaxStudent), x => x.MaxStudent },
                    { nameof(Course.CourseState), x => x.CourseState }
                };

                var selectedColumn = columnsSelector[orderBy];
                query = isDescending.HasValue && isDescending.Value
                    ? query.OrderByDescending(selectedColumn)
                    : query.OrderBy(selectedColumn);
            }

            var courses = await query
                .Skip((pagination.PageIndex - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();

            return (Data: courses, TotalRecords: totalRecords);
        }
    }
}