using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class TokenRepository : GenericRepository<Token>, ITokenRepository
    {
        public TokenRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Token> FindByUserIdAsync(Guid userId)
        {
            return await _dbContext.Tokens.FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}