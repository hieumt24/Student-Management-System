using StudentManagementSystem.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using StudentManagementSystem.Domain.Enums;

namespace StudentManagementSystem.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime? JoinedDate { get; set; }

        public string? StudentCode { get; set; }

        public string UserName { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public RoleType Role { get; set; }

        public LocationType Location { get; set; }

        public ICollection<StudentSemester>? StudentSemesters { get; set; }
        public Token? Token { get; set; }

        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}