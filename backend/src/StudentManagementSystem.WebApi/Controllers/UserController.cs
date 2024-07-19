using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddUserAsync(AddUserRequestDto request)
        {
            var response = await _userService.AddUserAsync(request);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUserAsync([FromQuery] PaginationFilter? filter, LocationType location, [FromQuery] string? search, [FromQuery] RoleType? role, [FromQuery] string? orderBy, [FromQuery] bool? isDescending)
        {
            var response = await _userService.GetAllUserAsync(filter, location, search, role, orderBy, isDescending);
            return Ok(response);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUserAsync([FromBody] EditUserRequestDto request, Guid userId)
        {
            var response = await _userService.UpdateUserAsync(request, userId);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserByIdAsync(Guid userId)
        {
            var response = await _userService.GetUserByIdAsync(userId);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUserAsync(Guid userId)
        {
            var response = await _userService.DeleteUserAsync(userId);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost]
        [Route("isValidDeletedUser/{userId}")]
        public async Task<IActionResult> IsValidDeletedUser(Guid userId)
        {
            var response = await _userService.IsValidDeletedUser(userId);
            return Ok(response);
        }
    }
}