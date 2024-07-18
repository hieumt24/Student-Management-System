using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Application.DTOs.Semesters.Responses
{
    public class SemesterResponseDto : BaseEntity
    {
        public string SemesterName { get; set; }
        public string SemesterCode { get; set; }
        public string AcademicYear { get; set; }
    }
}