using StudentManagementSystem.Domain.Common;

namespace StudentManagementSystem.Domain.Entities
{
    public class Token : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Value { get; set; }

        public User? User { get; set; }
    }
}