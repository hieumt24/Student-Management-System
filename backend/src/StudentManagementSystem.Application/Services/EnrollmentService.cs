using AutoMapper;
using FluentValidation;
using StudentManagementSystem.Application.DTOs.Enrollments.Requests;
using StudentManagementSystem.Application.DTOs.Enrollments.Responses;
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
        private readonly IValidator<AddEnrollmentRequestDto> _addEnrollmentValidator;

        public EnrollmentService
        (
                       IMapper mapper,
                                  IEnrollmentRepository enrollmentRepository,
                                             IValidator<AddEnrollmentRequestDto> addEnrollmentValidator
        )
        {
            _mapper = mapper;
            _enrollmentRepository = enrollmentRepository;
            _addEnrollmentValidator = addEnrollmentValidator;
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

                await _enrollmentRepository.AddAsync(enrollment);

                var enrollmentDto = _mapper.Map<EnrollmentDto>(enrollment);
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