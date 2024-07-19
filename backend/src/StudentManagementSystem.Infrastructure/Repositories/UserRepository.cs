using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;
using StudentManagementSystem.Domain.Exceptions;
using StudentManagementSystem.Infrastructure.Common;
using StudentManagementSystem.Infrastructure.DataAccess;
using System.Linq.Expressions;

namespace StudentManagementSystem.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<StudentSemester> AddStudentWithSemester(Guid studentId, Guid semesterId)
        {
            try
            {
                await _dbContext.StudentSemesters.AddAsync(new StudentSemester
                {
                    Id = Guid.NewGuid(),
                    StudentId = studentId,
                    SemesterId = semesterId,
                    CreatedOn = DateTime.Now
                });
                await _dbContext.SaveChangesAsync();
                return await _dbContext.StudentSemesters.FirstOrDefaultAsync(x => x.StudentId == studentId && x.SemesterId == semesterId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> CheckStudentCodeExsits(string studentCode)
        {
            var student = await _dbContext.Users.FirstOrDefaultAsync(x => x.StudentCode == studentCode && !x.IsDeleted);
            if (student is null)
            {
                return false;
            }
            return true;
        }

        public async Task<User> FindByUserNameAndEmail(string userName, string email)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == userName.ToLower() || x.Email.ToLower() == email.ToLower() && !x.IsDeleted);
            if (user is null)
            {
                return null;
            }
            return user;
        }

        public async Task<Guid> FindSesterIdByStudentId(Guid studentId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == studentId && !x.IsDeleted);

            if (user is null)
            {
                throw new NotFoundException(nameof(User), studentId.ToString());
            }

            var studentSemester = await _dbContext.StudentSemesters.FirstOrDefaultAsync(x => x.StudentId == user.Id);
            if (studentSemester is null)
            {
                throw new NotFoundException(nameof(StudentSemester), studentId.ToString());
            }
            return studentSemester.SemesterId;
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

        public async Task<(IEnumerable<User> Data, int TotalRecords)> GetAllMatchingUserAsync(PaginationFilter? pagination, LocationType location, string? search, RoleType? role, string? orderBy, bool? isDescending)
        {
            var query = _dbContext.Users.AsNoTracking()
                .Where(x => x.Location == location && !x.IsDeleted);

            string searchPhraseLower = search?.ToLower() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(searchPhraseLower))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(searchPhraseLower) ||
                                                        x.LastName.ToLower().Contains(searchPhraseLower) ||
                                                        x.StudentCode.ToLower().Contains(searchPhraseLower) ||
                                                        x.Email.ToLower().Contains(searchPhraseLower) ||
                                                        x.UserName.ToLower().Contains(searchPhraseLower));
            }

            if (role.HasValue)
            {
                query = query.Where(x => x.Role == role.Value);
            }

            var totalRecords = await query.CountAsync();

            if (!string.IsNullOrEmpty(orderBy))
            {
                var columnsSelector = new Dictionary<string, Expression<Func<User, object>>>
                {
                    { "fullname", x => x.FirstName + " " + x.LastName },
                    { "studentCode",  x => x.StudentCode },
                    { "email", x => x.Email },
                    { "firstName", x => x.FirstName },
                    { "lastName", x => x.LastName },
                    { "userName", x => x.UserName },
                    {"dateOfBirth", x => x.DateOfBirth},
                    { "joinedDate", x => x.JoinedDate },
                    {"gender", x => x.Gender },
                    { "role", x => x.Role },
                    {"createdon", x => x.CreatedOn },
                    { "lastmodifiedon", x => x.LastModifiedOn }
                };
                var selectedColumn = columnsSelector[orderBy];
                query = isDescending.HasValue && isDescending.Value
                    ? query.OrderByDescending(selectedColumn)
                    : query.OrderBy(selectedColumn);
            }
            //else default sort by StudentCode
            else
            {
                query = query.OrderBy(x => x.CreatedOn);
            }

            var users = await query.
                Skip((pagination.PageIndex - 1) * pagination.PageSize)
                .Take(pagination.PageSize)
                .ToListAsync();

            return (Data: users, TotalRecords: totalRecords);
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