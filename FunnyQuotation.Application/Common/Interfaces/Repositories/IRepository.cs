using System.Linq.Expressions;

namespace FunnyQuotation.Application.Common.Interfaces.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);

        Task<TEntity> FirstOrDefaultAsync(
            Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        Task UpdateAsync(TEntity entityToUpdate);

        Task DeleteAsync(TEntity entityToDelete);
    }
}
