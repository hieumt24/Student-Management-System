﻿using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
using StudentManagementSystem.Application.DTOs.Users.Requests;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IEnrollmentService
    {
        Task<Response<EnrollmentDto>> AddEnrollmentCourse(AddEnrollmentRequestDto request);

        Task<Response<EnrollmentDto>> StudentEnrollmentCourse(AddStudentEnrollmentRequestDto request);

        Task<Response<List<EnrollmentResponseDto>>> GetCourseById(Guid courseId);

        Task<Response<EnrollmentDto>> GetEnrollmentById(Guid enrollmentId);

        Task<Response<EnrollmentDto>> InsertGradeForStudnet(EditEnrollmentRequestDto request, Guid enrollmentId);

        Task<Response<List<EnrollmentResponseDto>>> GetReportGradeOfStudent(Guid studentId);

        Task<Response<List<EnrollmentResponseDto>>> GetReportGradeOfStudentForAdmin();

        Task<PagedResponse<List<EnrollmentResponseDto>>> GetAllEnrollmentOfStudents(PaginationFilter? pagination, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending);

        Task<PagedResponse<List<EnrollmentResponseDto>>> GetAllEnrollment(PaginationFilter? pagination, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending);
    }
}