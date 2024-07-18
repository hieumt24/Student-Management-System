using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<RoleType> GetRoleAsync(Guid userId);

        Task<string> GenerateUniqueUserName(string baseUserName);

        Task<bool> CheckStudentCodeExsits(string studentCode);

        Task<User> FindByUserNameAndEmail(string userName, string email);

        Task<Guid> FindSesterIdByStudentId(Guid studentId);

        Task<(IEnumerable<User> Data, int TotalRecords)> GetAllMatchingUserAsync(PaginationFilter? pagination, LocationType location, string? search, RoleType? role, string? orderBy, bool? isDescending);
    }
}