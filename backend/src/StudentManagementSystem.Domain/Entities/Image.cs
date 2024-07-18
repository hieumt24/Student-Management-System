using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Domain.Entities
{
    public class Image
    {
        public Guid Id { get; set; }

        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInBytes { get; set; }
        public string FilePath { get; set; }
    }
}