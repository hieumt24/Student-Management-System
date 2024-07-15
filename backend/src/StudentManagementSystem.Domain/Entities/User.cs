using StudentManagementSystem.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? JoinedDate { get; set; }

        [RegularExpression(@"^HE\d{6}$", ErrorMessage = "StudentCode must be in the format HExxxx where xxxx are digits.")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string StudentCode { get; set; } = string.Empty;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentCodeId { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public Token? Token { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}