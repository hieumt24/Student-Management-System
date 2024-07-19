using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IEnrollmentService
    {
        Task<Response<EnrollmentDto>> AddEnrollmentCourse(AddEnrollmentRequestDto request);

        Task<Response<EnrollmentDto>> StudentEnrollmentCourse(AddEnrollmentRequestDto request);

        //Task InsertGradeForStudent(AddGradeRequestDto request);
        Task<Response<List<EnrollmentResponseDto>>> GetCourseById(Guid courseId);

        Task<Response<EnrollmentDto>> InsertGradeForStudnet(EditEnrollmentRequestDto request);

        Task<PagedResponse<List<EnrollmentResponseDto>>> GetAllEnrollmentOfStudnet(PaginationFilter? pagination, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending);
    }
}