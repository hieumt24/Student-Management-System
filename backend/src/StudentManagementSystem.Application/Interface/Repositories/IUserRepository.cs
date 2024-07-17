using StudentManagementSystem.Application.Common;
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
    }
}