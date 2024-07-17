using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface ITokenService
    {
        Task<string> GenerateJwtToken(User user, RoleType role);
    }
}