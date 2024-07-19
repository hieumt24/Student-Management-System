using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Users.Requests;
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
        private readonly IEportDataService _eportDataService;

        public StudentController(IEnrollmentService enrollmentService, IEportDataService eportDataService)
        {
            _enrollmentService = enrollmentService;
            _eportDataService = eportDataService;
        }

        [HttpPost("enroll")]
        public async Task<IActionResult> EnrollCourse(AddStudentEnrollmentRequestDto request)
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
            var response = await _enrollmentService.GetAllEnrollmentOfStudents(filter, studentId, level, enrolmentStateType, isPassed, search, orderBy, isDescending);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet]
        [Route("exports")]
        public async Task<IActionResult> ExportGradeStudentToExcelAsync([FromQuery] Guid studentId)
        {
            var response = await _eportDataService.ExportGradeStudentToExcelAsync(studentId);
            return File(response, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "grades.xlsx");
        }
    }
}