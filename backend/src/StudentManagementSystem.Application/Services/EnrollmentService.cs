using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http.Timeouts;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Helpers;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Application.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IMapper _mapper;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IValidator<AddEnrollmentRequestDto> _addEnrollmentValidator;
        private readonly ICourseRepository _courseRepository;
        private readonly IValidator<EditEnrollmentRequestDto> _editEnrollmentValidator;

        public EnrollmentService
        (
                                            IMapper mapper,
                                            IEnrollmentRepository enrollmentRepository,
                                            IValidator<AddEnrollmentRequestDto> addEnrollmentValidator,
                                            IUserRepository userRepository,
                                            ICourseRepository courseRepository,
                                            IValidator<EditEnrollmentRequestDto> editEnrollmentValidator

        )
        {
            _mapper = mapper;
            _enrollmentRepository = enrollmentRepository;
            _addEnrollmentValidator = addEnrollmentValidator;
            _userRepository = userRepository;
            _courseRepository = courseRepository;
            _editEnrollmentValidator = editEnrollmentValidator;
        }

        public async Task<Response<EnrollmentDto>> AddEnrollmentCourse(AddEnrollmentRequestDto request)
        {
            var validationResult = await _addEnrollmentValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<EnrollmentDto> { Succeeded = false, Errors = errors };
            }
            try
            {
                var enrollment = _mapper.Map<Enrollment>(request);

                enrollment.CreatedOn = DateTime.Now;

                enrollment.SemesterId = await _userRepository.FindSesterIdByStudentId(request.StudentId);
                await _enrollmentRepository.AddAsync(enrollment);

                var enrollmentDto = _mapper.Map<EnrollmentDto>(enrollment);
                return new Response<EnrollmentDto> { Succeeded = true, Data = enrollmentDto };
            }
            catch (Exception ex)
            {
                return new Response<EnrollmentDto> { Succeeded = false, Message = ex.Message };
            }
        }

        public async Task<PagedResponse<List<EnrollmentResponseDto>>> GetAllEnrollmentOfStudnet(PaginationFilter? pagination, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
        {
            try
            {
                var enrollmentOfStudent = await _enrollmentRepository.GetAllEnrollmentOfStudent(pagination, studentId, level, enrolmentStateType, isPassed, search, orderBy, isDescending);
                if (enrollmentOfStudent.Data is null)
                {
                    return new PagedResponse<List<EnrollmentResponseDto>> { Succeeded = false, Message = "Enrollment not found" };
                }
                var enrollmentResponseDto = _mapper.Map<List<EnrollmentResponseDto>>(enrollmentOfStudent.Data);

                var pagedResponse = PaginationHelper.CreatePageResponse(enrollmentResponseDto, pagination, enrollmentOfStudent.TotalRecords);
                return pagedResponse;
            }
            catch (Exception ex)
            {
                return new PagedResponse<List<EnrollmentResponseDto>> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<Response<List<EnrollmentResponseDto>>> GetCourseById(Guid courseId)
        {
            try
            {
                var course = await _enrollmentRepository.GetCourseById(courseId);
                if (course is null)
                {
                    return new Response<List<EnrollmentResponseDto>> { Succeeded = false, Message = "Course not found" };
                }
                var courseResponseDto = _mapper.Map<List<EnrollmentResponseDto>>(course);
                return new Response<List<EnrollmentResponseDto>> { Succeeded = true, Data = courseResponseDto };
            }
            catch (Exception ex)
            {
                return new Response<List<EnrollmentResponseDto>> { Succeeded = false, Message = ex.Message };
            }
        }

        public async Task<Response<EnrollmentDto>> InsertGradeForStudnet(EditEnrollmentRequestDto request)
        {
            try
            {
                var enrollment = _mapper.Map<Enrollment>(request);

                var existingEnrollment = await _enrollmentRepository.GetByIdAsync(enrollment.Id);
                if (existingEnrollment is null)
                {
                    return new Response<EnrollmentDto> { Succeeded = false, Message = "Enrollment not found" };
                }
                var validationResult = await _editEnrollmentValidator.ValidateAsync(request);
                if (!validationResult.IsValid)
                {
                    var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                    return new Response<EnrollmentDto> { Succeeded = false, Errors = errors };
                }
                existingEnrollment.Grade = enrollment.Grade;

                //Check if Grade >= 5.0 then isPassed = true
                await _enrollmentRepository.CheckStudentPassCourse(existingEnrollment.Id, request.Grade);

                await _enrollmentRepository.UpdateAsync(existingEnrollment);

                var enrollmentDto = _mapper.Map<EnrollmentDto>(existingEnrollment);
                return new Response<EnrollmentDto> { Succeeded = true, Data = enrollmentDto };
            }
            catch (Exception ex)
            {
                return new Response<EnrollmentDto> { Succeeded = false, Message = ex.Message };
            }
        }

        public async Task<Response<EnrollmentDto>> StudentEnrollmentCourse(AddEnrollmentRequestDto request)
        {
            var validationResult = await _addEnrollmentValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<EnrollmentDto> { Succeeded = false, Errors = errors };
            }
            try
            {
                var enrollment = _mapper.Map<Enrollment>(request);

                enrollment.CreatedOn = DateTime.Now;
                enrollment.Grade = 0;
                enrollment.State = EnrolmentStateType.Enrolled;
                enrollment.IsPassed = false;
                enrollment.SemesterId = await _userRepository.FindSesterIdByStudentId(request.StudentId);

                var checkedCourseFullSlot = await _courseRepository.CheckCourseFullSlot(request.CourseId);
                if (checkedCourseFullSlot)
                {
                    return new Response<EnrollmentDto> { Succeeded = false, Message = "Course is full slot" };
                }

                await _enrollmentRepository.AddAsync(enrollment);

                var enrollmentDto = _mapper.Map<EnrollmentDto>(enrollment);
                return new Response<EnrollmentDto> { Succeeded = true, Data = enrollmentDto };
            }
            catch (Exception ex)
            {
                return new Response<EnrollmentDto> { Succeeded = false, Message = ex.Message };
            }
        }
    }
}