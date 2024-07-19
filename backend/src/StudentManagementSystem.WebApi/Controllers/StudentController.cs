using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.Interface.Services;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public StudentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpPost("enroll")]
        public async Task<IActionResult> EnrollCourse(AddEnrollmentRequestDto request)
        {
            var response = await _enrollmentService.StudentEnrollmentCourse(request);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}