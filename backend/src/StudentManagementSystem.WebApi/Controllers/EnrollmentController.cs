﻿using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.Interface.Services;

namespace StudentManagementSystem.WebApi.Controllers
{
    [Route("api/v1/enrollments")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
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

        [HttpPut]
        public async Task<IActionResult> InsertGradeForStudnet(EditEnrollmentRequestDto request)
        {
            var response = await _enrollmentService.InsertGradeForStudnet(request);
            if (response.Succeeded)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}