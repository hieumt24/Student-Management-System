using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.DTOs.Semesters.Responses;
using StudentManagementSystem.Application.Filters;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface ISemesterService
    {
        Task<Response<SemesterDto>> AddSemesterAsync(AddSemesterRequestDto request);

        Task<PagedResponse<List<SemesterResponseDto>>> GetAllSemesters(PaginationFilter? pagination, string? search, string? orderBy, bool? isDescending);
    }
}