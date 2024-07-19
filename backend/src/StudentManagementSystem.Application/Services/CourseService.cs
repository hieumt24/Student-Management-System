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
        private readonly IEnrollmentRepository _enrollmentRepository;

        public CourseService
        (
        IMapper mapper,
         ICourseRepository courseRepository,
         IValidator<AddCourseRequestDto> addCourseValidator,
         IEnrollmentRepository enrollmentRepository
         )
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
            _addCourseValidator = addCourseValidator;
            _enrollmentRepository = enrollmentRepository;
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

                var checkCourseCode = await _courseRepository.CheckCourseCodeExsiting(course.CourseCode);
                if (checkCourseCode)
                {
                    return new Response<CourseDto> { Succeeded = false, Message = "Course code already exists" };
                }

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

        public async Task<Response<CourseResponseDto>> GetCourseByIdAsync(Guid courseId)
        {
            try
            {
                var course = await _courseRepository.GetByIdAsync(courseId);
                if (course is null)
                {
                    return new Response<CourseResponseDto> { Succeeded = false, Message = "Course not found" };
                }
                var courseResponseDto = _mapper.Map<CourseResponseDto>(course);
                return new Response<CourseResponseDto> { Succeeded = true, Data = courseResponseDto };
            }
            catch (Exception ex)
            {
                return new Response<CourseResponseDto> { Succeeded = false, Message = ex.Message };
            }
        }

        //edit course
        public async Task<Response<CourseResponseDto>> UpdateCourseAsync(Guid courseId, EditCourseRequestDto request)
        {
            try
            {
                var course = await _courseRepository.GetByIdAsync(courseId);
                if (course is null)
                {
                    return new Response<CourseResponseDto> { Succeeded = false, Message = "Course not found" };
                }

                course = _mapper.Map(request, course);
                course.LastModifiedOn = DateTime.Now;

                await _courseRepository.UpdateAsync(course);

                var courseResponseDto = _mapper.Map<CourseResponseDto>(course);
                return new Response<CourseResponseDto> { Succeeded = true, Data = courseResponseDto };
            }
            catch (Exception ex)
            {
                return new Response<CourseResponseDto> { Succeeded = false, Message = ex.Message };
            }
        }
    }
}