using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogN.Data.Repositories.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<ICollection<T>> GetAll(Expression<Func<T,bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);
        Task<T> Get(int id);
        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, 
            string includeProperties = null);
        Task<bool> Add(T entity);
        T Update(T entity);
        bool Delete(int id);
    }
}
