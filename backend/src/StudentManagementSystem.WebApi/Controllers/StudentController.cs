using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Domain.Enums;

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

        [HttpGet("enrollments")]
        public async Task<IActionResult> GetAllEnrollmentsOfStudent([FromQuery] PaginationFilter? filter, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
        {
            var response = await _enrollmentService.GetAllEnrollmentOfStudnet(filter, studentId, level, enrolmentStateType, isPassed, search, orderBy, isDescending);
            return Ok(response);
        }
    }
}