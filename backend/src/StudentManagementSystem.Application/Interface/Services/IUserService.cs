using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.DTOs.Users.Responses;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IUserService
    {
        Task<Response<UserDto>> AddUserAsync(AddUserRequestDto request);
    }
}