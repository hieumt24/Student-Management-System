using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class BlackListTokenRepository : GenericRepository<BlackListToken>, IBlackListTokenRepository
    {
        public BlackListTokenRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}