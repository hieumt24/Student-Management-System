using AutoMapper;
using FluentValidation;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.DTOs.Semesters.Responses;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;

namespace StudentManagementSystem.Application.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly IMapper _mapper;
        private readonly ISemesterRepository _semesterRepository;
        private readonly IValidator<AddSemesterRequestDto> _addSemesterValidator;

        public SemesterService
        (
            IMapper mapper,
            ISemesterRepository semesterRepository,
            IValidator<AddSemesterRequestDto> addSemesterValidator
        )
        {
            _mapper = mapper;
            _semesterRepository = semesterRepository;
            _addSemesterValidator = addSemesterValidator;
        }

        public async Task<Response<SemesterDto>> AddSemesterAsync(AddSemesterRequestDto request)
        {
            var validationResult = await _addSemesterValidator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                return new Response<SemesterDto> { Succeeded = false, Errors = errors };
            }

            try
            {
                var semester = _mapper.Map<Semester>(request);

                semester.CreatedOn = DateTime.Now;

                await _semesterRepository.AddAsync(semester);

                var semesterDto = _mapper.Map<SemesterDto>(semester);

                return new Response<SemesterDto> { Succeeded = true, Data = semesterDto };
            }
            catch (Exception ex)
            {
                return new Response<SemesterDto> { Succeeded = false, Message = ex.Message };
            }
        }
    }
}