using StudentManagementSystem.Application.DTOs.Semesters.Requests;
using StudentManagementSystem.Application.DTOs.Semesters.Responses;
using StudentManagementSystem.Application.Wrappers;

namespace StudentManagementSystem.Application.Interface.Services
{
    public interface ISemesterService
    {
        Task<Response<SemesterDto>> AddSemesterAsync(AddSemesterRequestDto request);
    }
}