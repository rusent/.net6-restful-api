using BlogN.Data.Repositories.IRepository;
using BlogN.Models;
using System.Linq.Expressions;

namespace BlogN.Data.Repositories.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<bool> Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> GetAll(Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetFirstOrDefault(Expression<Func<Category, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
