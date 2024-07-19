using AutoMapper;
using FluentValidation;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Helpers;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        private readonly IValidator<AddCourseRequestDto> _addCourseValidator;

        public CourseService
        (
        IMapper mapper,
         ICourseRepository courseRepository,
         IValidator<AddCourseRequestDto> addCourseValidator
         )
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
            _addCourseValidator = addCourseValidator;
        }

        public async Task<Response<CourseDto>> AddCourseAsync(AddCourseRequestDto request)
        {
            var validationResult = await _addCourseValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<CourseDto> { Succeeded = false, Errors = errors };
            }
            try
            {
                var course = _mapper.Map<Course>(request);

                course.CreatedOn = DateTime.Now;

                await _courseRepository.AddAsync(course);

                var courseDto = _mapper.Map<CourseDto>(course);
                return new Response<CourseDto> { Succeeded = true, Data = courseDto };
            }
            catch (Exception ex)
            {
                return new Response<CourseDto> { Succeeded = false, Message = ex.Message };
            }
        }

        public async Task<PagedResponse<List<CourseResponseDto>>> GetAllCoursesAsync(PaginationFilter? pagination, CourseLevelType? courseLevel, CourseStateType? courseState, string? search, string? orderBy, bool? isDescending)
        {
            try
            {
                var courses = await _courseRepository.GetAllMatchingCourse(pagination, courseLevel, courseState, search, orderBy, isDescending);
                if (courses.Data is null)
                {
                    return new PagedResponse<List<CourseResponseDto>> { Succeeded = false, Message = "No courses found" };
                }
                var courseResponseDto = _mapper.Map<List<CourseResponseDto>>(courses.Data);
                var pagedResponse = PaginationHelper.CreatePageResponse(courseResponseDto, pagination, courses.TotalRecords);

                return pagedResponse;
            }
            catch (Exception ex)
            {
                return new PagedResponse<List<CourseResponseDto>> { Succeeded = false, Message = ex.Message };
            }
        }
    }
}