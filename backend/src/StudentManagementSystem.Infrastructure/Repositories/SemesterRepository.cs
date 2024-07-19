using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;
using System.Linq.Expressions;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class SemesterRepository : GenericRepository<Semester>, ISemesterRepository
    {
        public SemesterRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CheckSemesterCodeExisiting(string semesterName, string academicYear)
        {
            var isSemesterCodeExisting = await _dbContext.Semesters.FirstOrDefaultAsync(x => x.AcademicYear.ToLower().Equals(academicYear.ToLower()) && x.SemesterName.ToLower().Equals(semesterName.ToLower()));
            if (isSemesterCodeExisting != null)
            {
                return true;
            }
            return false;
        }

        public async Task<(IEnumerable<Semester> Data, int TotalRecords)> GetAllMatchingSemester(PaginationFilter? pagination, string? search, string? orderBy, bool? isDescending)
        {
            var query = _dbContext.Semesters.AsNoTracking();

            string searchPhraseLower = search?.ToLower() ?? string.Empty;

            if (!string.IsNullOrEmpty(searchPhraseLower))
            {
                query = query.Where(x => x.SemesterCode.ToLower().Contains(searchPhraseLower));
            }

            var totalRecords = await query.CountAsync();

            if (!string.IsNullOrEmpty(orderBy))
            {
                var columnsSelector = new Dictionary<string, Expression<Func<Semester, object>>>
                {
                    {"semesterCode", x => x.SemesterCode }
                };
                if (columnsSelector.ContainsKey(orderBy.ToLower()))
                {
                    query = isDescending.HasValue && isDescending.Value
                        ? query.OrderByDescending(columnsSelector[orderBy])
                        : query.OrderBy(columnsSelector[orderBy]);
                }
            }
            var semesters = await query
                .Skip((pagination.PageIndex - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();
            return (Data: semesters, TotalRecords: totalRecords);
        }
    }
}