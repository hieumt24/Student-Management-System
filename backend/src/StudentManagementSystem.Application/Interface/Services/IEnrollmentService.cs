using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IEnrollmentService
    {
        Task<Response<EnrollmentDto>> AddEnrollmentCourse(AddEnrollmentRequestDto request);

        Task<Response<EnrollmentDto>> StudentEnrollmentCourse(AddEnrollmentRequestDto request);
    }
}