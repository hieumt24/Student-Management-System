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
        [EnableQuery]
        public async Task<IActionResult> GetAllUserAsync([FromQuery] PaginationFilter filter, LocationType location)
        {
            var response = await _userService.GetAllUserAsync(filter, location);
            return Ok(response);
        }
    }
}