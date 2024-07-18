using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Auth.Requests;
using StudentManagementSystem.Application.Interface.Services;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> LoginAsync([FromBody] AuthenticationRequest request)
        {
            var response = await _authService.LoginAsync(request);
            if (!response.Succeeded)
            {
                return Unauthorized(response);
            }
            return Ok(response);
        }
    }
}