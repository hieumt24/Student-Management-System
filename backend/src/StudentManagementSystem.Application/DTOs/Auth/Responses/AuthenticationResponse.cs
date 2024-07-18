namespace StudentManagementSystem.Application.DTOs.Auth.Responses
{
    public class AuthenticationResponse
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public string Token { get; set; }
    }
}