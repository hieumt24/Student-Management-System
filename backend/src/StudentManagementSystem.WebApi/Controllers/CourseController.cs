using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCourseAsync(AddCourseRequestDto request)
        {
            var response = await _courseService.AddCourseAsync(request);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCoursesAsync([FromQuery] PaginationFilter? pagination, CourseLevelType? courseLevel, CourseStateType? courseState, string? search, string? orderBy, bool? isDescending)
        {
            var response = await _courseService.GetAllCoursesAsync(pagination, courseLevel, courseState, search, orderBy, isDescending);
            return Ok(response);
        }
    }
}