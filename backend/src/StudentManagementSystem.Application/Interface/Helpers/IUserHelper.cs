namespace StudentManagementSystem.Application.Interface.Helpers
{
    public interface IUserHelper
    {
        Task<string> GenerateUserName(string firstName, string lastName);

        Task<string> GenerateUserEmail(string userName, string studentCode);

        Task<string> GenerateDefaultPassword(string userName, DateTime dateOfBirth);
    }
}