using AutoMapper;
using FluentValidation;
using StudentManagementSystem.Application.DTOs.Courses.Requests;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;

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

        public async Task<Response<CourseResponseDto>> AddCourseAsync(AddCourseRequestDto request)
        {
            var validationResult = await _addCourseValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<CourseResponseDto> { Succeeded = false, Errors = errors };
            }
            try
            {
                var course = _mapper.Map<Course>(request);

                course.CreatedOn = DateTime.Now;

                await _courseRepository.AddAsync(course);

                var courseDto = _mapper.Map<CourseResponseDto>(course);
                return new Response<CourseResponseDto> { Succeeded = true, Data = courseDto };
            }
            catch (Exception ex)
            {
                return new Response<CourseResponseDto> { Succeeded = false, Message = ex.Message };
            }
        }
    }
}