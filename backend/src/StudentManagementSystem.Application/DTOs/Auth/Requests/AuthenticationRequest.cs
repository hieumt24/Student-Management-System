using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Application.DTOs.Auth.Requests
{
    public class AuthenticationRequest
    {
        [MaxLength(50)]
        public string? Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}