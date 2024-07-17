using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;
using StudentManagementSystem.Domain.Exceptions;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> CheckStudentCodeExsits(string studentCode)
        {
            var student = _dbContext.Users.FirstOrDefaultAsync(x => x.StudentCode == studentCode);
            if (student is null)
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public async Task<string> GenerateUniqueUserName(string baseUserName)
        {
            var matchingUserNames = await _dbContext.Users
                .Where(u => u.UserName.StartsWith(baseUserName)).
                Select(u => u.UserName).ToListAsync();
            if (matchingUserNames.Count == 0)
            {
                return baseUserName;
            }
            int maxNumber = 0;

            foreach (var userName in matchingUserNames)
            {
                string numericPart = userName.Substring(baseUserName.Length);
                if (int.TryParse(numericPart, out int number))
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
            }

            return baseUserName + (maxNumber + 1);
        }

        public async Task<RoleType> GetRoleAsync(Guid userId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user is null)
            {
                throw new NotFoundException(nameof(User), userId.ToString());
            }
            return user.Role;
        }
    }
}