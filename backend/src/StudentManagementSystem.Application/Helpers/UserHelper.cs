using StudentManagementSystem.Application.Interface.Helpers;
using StudentManagementSystem.Application.Interface.Repositories;

namespace StudentManagementSystem.Application.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly IUserRepository _userRepository;

        public UserHelper(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<string> GenerateDefaultPassword(string userName, DateTime dateOfBirth)
        {
            return Task.FromResult($"{userName}@{dateOfBirth:ddMMyyyy}");
        }

        public Task<string> GenerateUserEmail(string userName, string studentCode)
        {
            return Task.FromResult($"{userName}{studentCode}@fpt.edu.vn");
        }

        public Task<string> GenerateUserName(string firstName, string lastName)
        {
            firstName = firstName.ToLower().Replace(" ", "");
            lastName = string.Join(" ", lastName.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            var lastNameParts = lastName.Split(' ');
            var lastNameInitials = string.Join("", lastNameParts.Select(part => part[0]));

            string baseUserName = firstName + lastNameInitials;

            return _userRepository.GenerateUniqueUserName(baseUserName);
        }
    }
}