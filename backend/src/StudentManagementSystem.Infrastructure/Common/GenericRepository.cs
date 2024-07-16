using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Application.Common;
using StudentManagementSystem.Domain.Common;
using StudentManagementSystem.Domain.Exceptions;
using StudentManagementSystem.Infrastructure.DataAccess;
using System.Linq.Expressions;

namespace StudentManagementSystem.Infrastructure.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            try { await _dbContext.SaveChangesAsync(); }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().CountAsync(predicate);
        }

        public async Task<T> DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            if (entity is null)
            {
                throw new NotFoundException(typeof(T).Name, id.ToString());
            }
            entity.IsDeleted = true;
            await UpdateAsync(entity);
            return entity;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().Where(x => !x.IsDeleted).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            if (entity is null)
            {
                throw new NotFoundException(typeof(T).Name, id.ToString());
            }
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return entity;
        }
    }
}