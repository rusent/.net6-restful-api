using System.Linq.Expressions;

namespace BlogN.Data.Services.IService
{
    public interface IService<T> where T : class
    {
        Task<ICollection<T>> GetAll(Expression<Func<T, bool>> filter = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        Task<T> Get(int id);
        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null,
            string includeProperties = null);
        Task<bool> Add(T entity);
        T Update(T entity);
        bool Delete(int id);
    }
}
