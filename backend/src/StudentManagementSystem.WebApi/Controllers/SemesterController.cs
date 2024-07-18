using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Services;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/semesters")]
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

        [HttpGet]
        public async Task<IActionResult> GetAllSemesters([FromQuery] PaginationFilter? pagination, [FromQuery] string? search, [FromQuery] string? orderBy, [FromQuery] bool? isDescending)
        {
            var response = await _semesterService.GetAllSemesters(pagination, search, orderBy, isDescending);
            return Ok(response);
        }
    }
}