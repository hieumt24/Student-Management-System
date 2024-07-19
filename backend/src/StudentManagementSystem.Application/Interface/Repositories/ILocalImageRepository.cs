using StudentManagementSystem.Application.Models;

namespace StudentManagementSystem.Application.Interface.Repositories
{
    public interface ILocalImageRepository
    {
        Task<Image> Upload(Image image);
    }
}