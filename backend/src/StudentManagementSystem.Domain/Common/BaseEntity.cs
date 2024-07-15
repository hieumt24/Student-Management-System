using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Domain.Common
{
    public class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; } = Guid.NewGuid();

        public string? CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}