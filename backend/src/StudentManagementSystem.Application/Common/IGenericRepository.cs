using System.Linq.Expressions;

namespace StudentManagementSystem.Application.Common
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);

        //Get all condition
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<T> DeleteAsync(Guid id);

        //Count condition
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}