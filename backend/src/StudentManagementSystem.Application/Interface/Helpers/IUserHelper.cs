namespace StudentManagementSystem.Application.Interface.Helpers
{
    public interface IUserHelper
    {
        Task<string> GenerateUserName(string firstName, string lastName);

        Task<string> GenerateUserEmail(string userName, string studentCode);

        string GenerateDefaultPassword(string userName, DateTime dateOfBirth);

        Task<string> GenerateStudentCode();
    }
}