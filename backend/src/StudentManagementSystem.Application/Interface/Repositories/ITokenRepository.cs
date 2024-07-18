using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface ITokenRepository : IGenericRepository<Token>
    {
        Task<Token> FindByUserIdAsync(Guid userId);
    }
}