using AutoMapper;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;

        public Task<Response<CourseResponseDto>> CreateCourseAsync(AddCourseRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}