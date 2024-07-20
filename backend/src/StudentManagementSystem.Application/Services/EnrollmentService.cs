using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http.Timeouts;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
using StudentManagementSystem.Application.DTOs.Users.Requests;
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
        private readonly IValidator<AddStudentEnrollmentRequestDto> _addStudentEnrollmentValidator;

        public EnrollmentService
        (
                                            IMapper mapper,
                                            IEnrollmentRepository enrollmentRepository,
                                            IValidator<AddEnrollmentRequestDto> addEnrollmentValidator,
                                            IUserRepository userRepository,
                                            ICourseRepository courseRepository,
                                            IValidator<EditEnrollmentRequestDto> editEnrollmentValidator,
                                            IValidator<AddStudentEnrollmentRequestDto> addStudentEnrollmentValidator

        )
        {
            _mapper = mapper;
            _enrollmentRepository = enrollmentRepository;
            _addEnrollmentValidator = addEnrollmentValidator;
            _userRepository = userRepository;
            _courseRepository = courseRepository;
            _editEnrollmentValidator = editEnrollmentValidator;
            _addStudentEnrollmentValidator = addStudentEnrollmentValidator;
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

        public async Task<PagedResponse<List<EnrollmentResponseDto>>> GetAllEnrollment(PaginationFilter? pagination, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
        {
            try
            {
                var enrollments = await _enrollmentRepository.GetAllEnrollments(pagination, level, enrolmentStateType, isPassed, search, orderBy, isDescending);
                if (enrollments.Data is null)
                {
                    return new PagedResponse<List<EnrollmentResponseDto>> { Succeeded = false, Message = "Enrollment not found" };
                }
                var enrollmentResponseDto = _mapper.Map<List<EnrollmentResponseDto>>(enrollments.Data);

                var pagedResponse = PaginationHelper.CreatePageResponse(enrollmentResponseDto, pagination, enrollments.TotalRecords);
                return pagedResponse;
            }
            catch (Exception ex)
            {
                return new PagedResponse<List<EnrollmentResponseDto>> { Succeeded = false, Errors = new List<string> { ex.Message } };
            }
        }

        public async Task<PagedResponse<List<EnrollmentResponseDto>>> GetAllEnrollmentOfStudents(PaginationFilter? pagination, Guid studentId, CourseLevelType? level, EnrolmentStateType? enrolmentStateType, bool? isPassed, string? search, string? orderBy, bool? isDescending)
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

        public async Task<Response<List<EnrollmentResponseDto>>> GetReportGradeOfStudent(Guid studentId)
        {
            try
            {
                var reportGrade = await _enrollmentRepository.GetReportStudentInEnrollment(studentId);
                if (reportGrade is null)
                {
                    return new Response<List<EnrollmentResponseDto>> { Succeeded = false, Message = "Report grade not found" };
                }
                var reportGradeResponseDto = _mapper.Map<List<EnrollmentResponseDto>>(reportGrade);
                return new Response<List<EnrollmentResponseDto>> { Succeeded = true, Data = reportGradeResponseDto };
            }
            catch (Exception ex)
            {
                return new Response<List<EnrollmentResponseDto>> { Succeeded = false, Message = ex.Message };
            }
        }

        public async Task<Response<EnrollmentDto>> InsertGradeForStudnet(EditEnrollmentRequestDto request, Guid enrollmentId)
        {
            try
            {
                var enrollment = _mapper.Map<Enrollment>(request);

                var existingEnrollment = await _enrollmentRepository.GetByIdAsync(enrollmentId);
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

        public async Task<Response<EnrollmentDto>> StudentEnrollmentCourse(AddStudentEnrollmentRequestDto request)
        {
            var validationResult = await _addStudentEnrollmentValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<EnrollmentDto> { Succeeded = false, Errors = errors };
            }
            try
            {
                var checkStudentInEnrollment = await _enrollmentRepository.CheckUserExsitingInEnrollment(request.CourseId, request.StudentId);

                if (checkStudentInEnrollment)
                {
                    return new Response<EnrollmentDto> { Succeeded = false, Message = "Student already enrolled in this course" };
                }

                var enrollment = _mapper.Map<Enrollment>(request);

                enrollment.CreatedOn = DateTime.Now;
                enrollment.Grade = 0;
                enrollment.State = EnrolmentStateType.Enrolled;
                enrollment.IsPassed = false;
                enrollment.SemesterId = await _userRepository.FindSesterIdByStudentId(request.StudentId);

                var checkedCourseFullSlot = await _courseRepository.CheckCourseFullSlot(request.CourseId);
                if (checkedCourseFullSlot)
                {
                    await _courseRepository.UpdateStateCourse(enrollment.CourseId, CourseStateType.InProgress);
                    return new Response<EnrollmentDto> { Succeeded = false, Message = "Course is full slot" };
                }
                var course = await _courseRepository.GetByIdAsync(request.CourseId);

                if (course is null)
                {
                    return new Response<EnrollmentDto> { Succeeded = false, Message = "Course not found" };
                }
                course.StudentInCourse = await _enrollmentRepository.CountStudentInCourse(course.Id);

                await _courseRepository.UpdateAsync(course);
                var studentInCourse = await _enrollmentRepository.CountStudentInCourse(request.CourseId);

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