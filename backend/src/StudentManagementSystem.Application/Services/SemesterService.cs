using AutoMapper;
using FluentValidation;
using StudentManagementSystem.Application.DTOs.Courses.Responses;
using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.DTOs.Semesters.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Helpers;
using StudentManagementSystem.Application.Interface.Repositories;
using StudentManagementSystem.Application.Interface.Services;
using StudentManagementSystem.Application.Wrappers;
using StudentManagementSystem.Domain.Entities;
using System.Net.Http.Headers;

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

                var isSemesterCodeExisting = await _semesterRepository.CheckSemesterCodeExisiting(semester.SemesterName, semester.AcademicYear);
                if (isSemesterCodeExisting)
                {
                    return new Response<SemesterDto> { Succeeded = false, Message = "Semester code already exists" };
                }

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

        public async Task<PagedResponse<List<SemesterResponseDto>>> GetAllSemesters(PaginationFilter? pagination, string? search, string? orderBy, bool? isDescending)
        {
            try
            {
                var semesters = await _semesterRepository.GetAllMatchingSemester(pagination, search, orderBy, isDescending);
                if (semesters.Data == null)
                {
                    return new PagedResponse<List<SemesterResponseDto>> { Succeeded = false, Message = "No semesters found" };
                }
                //var semesterResponseDto = _mapper.Map<List<SemesterResponseDto>>(semesters.Data);
                var semesterResponseDto = semesters.Data.Select(semester => new SemesterResponseDto
                {
                    SemesterName = semester.SemesterName,
                    SemesterCode = semester.SemesterCode,
                    AcademicYear = semester.AcademicYear,
                    Courses = semester.Courses.Select(course => new CourseDto
                    {
                        CourseCode = course.CourseCode,
                        Title = course.Title,
                        Credits = course.Credits,
                        MaxStudent = course.MaxStudent
                    }).ToList()
                });
                var pagedResponse = PaginationHelper.CreatePageResponse(semesterResponseDto.ToList(), pagination, semesters.TotalRecords);
                return pagedResponse;
            }
            catch (Exception ex)
            {
                return new PagedResponse<List<SemesterResponseDto>> { Succeeded = false, Message = ex.Message };
            }
        }
    }
}