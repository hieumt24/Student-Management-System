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

        public string GenerateDefaultPassword(string userName, DateTime dateOfBirth)
        {
            return $"{userName}@{dateOfBirth:ddMMyyyy}";
        }

        public async Task<string> GenerateStudentCode()
        {
            const string prefix = "HE";
            const int maxNumber = 999999;

            for (int currentNumber = 1; currentNumber <= maxNumber; currentNumber++)
            {
                string studentCode = $"{prefix}{currentNumber:D6}";
                bool existingStudentCode = await _userRepository.CheckStudentCodeExsits(studentCode);

                if (!existingStudentCode)
                {
                    return studentCode;
                }
            }

            throw new Exception($"{prefix} student code is full");
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