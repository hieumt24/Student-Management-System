using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface ICourseService
    {
        Task<Response<CourseDto>> AddCourseAsync(AddCourseRequestDto request);

        Task<PagedResponse<List<CourseResponseDto>>> GetAllCoursesAsync(PaginationFilter? pagination, CourseLevelType? courseLevel, CourseStateType? courseState, string? search, string? orderBy, bool? isDescending);

        Task<Response<CourseResponseDto>> GetCourseByIdAsync(Guid courseId);

        Task<Response<CourseResponseDto>> UpdateCourseAsync(Guid courseId, EditCourseRequestDto request);
    }
}