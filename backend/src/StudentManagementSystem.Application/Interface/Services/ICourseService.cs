using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface ICourseService
    {
        Task<Response<CourseResponseDto>> AddCourseAsync(AddCourseRequestDto request);
    }
}