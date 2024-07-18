using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.Interface.Services;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/semesters")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterService _semesterService;

        public SemesterController(ISemesterService semesterService)
        {
            _semesterService = semesterService;
        }

        [HttpPost]
        public async Task<IActionResult> AddSemesterAsync(AddSemesterRequestDto request)
        {
            var response = await _semesterService.AddSemesterAsync(request);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}