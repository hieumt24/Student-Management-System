using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.DTOs.Users.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IUserService
    {
        Task<Response<UserDto>> AddUserAsync(AddUserRequestDto request);

        Task<PagedResponse<List<UserResponseDto>>> GetAllUserAsync(PaginationFilter? filter, LocationType location, string? search, RoleType? role, string? orderBy, bool? isDescending);
    }
}