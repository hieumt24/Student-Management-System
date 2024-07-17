using StudentManagementSystem.Application.DTOs.Auth.Requests;
using StudentManagementSystem.Application.DTOs.Auth.Responses;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IAuthService
    {
        Task<Response<AuthenticationResponse>> LoginAsync(AuthenticationRequest request);

        Task<Response<string>> ChangePasswordAsync(ChangePasswordRequest request);
    }
}