using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/enrollments")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;
        private readonly IEportDataService _eportDataService;

        public EnrollmentController(IEnrollmentService enrollmentService, IEportDataService eportDataService)
        {
            _enrollmentService = enrollmentService;
            _eportDataService = eportDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEnrollments([FromQuery] PaginationFilter? filter, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
        {
            var response = await _enrollmentService.GetAllEnrollment(filter, level, enrolmentStateType, isPassed, search, orderBy, isDescending);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddEnrollmentCourse(AddEnrollmentRequestDto request)
        {
            var response = await _enrollmentService.AddEnrollmentCourse(request);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet]
        [Route("course/{courseId}")]
        public async Task<IActionResult> GetCourseById(Guid courseId)
        {
            var response = await _enrollmentService.GetCourseById(courseId);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpPut("{enrollmentId}")]
        public async Task<IActionResult> InsertGradeForStudnet(EditEnrollmentRequestDto request, Guid enrollmentId)
        {
            var response = await _enrollmentService.InsertGradeForStudnet(request, enrollmentId);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{enrollmentId}")]
        public async Task<IActionResult> GetEnrollmentById(Guid enrollmentId)
        {
            var response = await _enrollmentService.GetEnrollmentById(enrollmentId);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet]
        [Route("report")]
        public async Task<IActionResult> GetReportGradeOfStudentForAdmin()
        {
            var response = await _eportDataService.ExportGradeStudentToExcelAsyncForAdmin();
            return File(response, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ExportGradeStudent.xlsx");
        }
    }
}