namespace StudentManagementSystem.Application.Interface.Services
{
    public interface IEportDataService
    {
        Task<byte[]> ExportGradeStudentToExcelAsync(Guid studentId);

        Task<byte[]> ExportGradeStudentToExcelAsyncForAdmin();
    }
}