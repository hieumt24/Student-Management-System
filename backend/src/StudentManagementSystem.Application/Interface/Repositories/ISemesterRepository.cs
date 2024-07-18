using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface ISemesterRepository : IGenericRepository<Semester>
    {
        Task<(IEnumerable<Semester> Data, int TotalRecords)> GetAllMatchingSemester(PaginationFilter? pagination, string? search, string? orderBy, bool? isDescending);

        Task<bool> CheckSemesterCodeExisiting(string semesterName, string academicYear);
    }
}