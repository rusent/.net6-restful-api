using BlogN.Data.Repositories.IRepository;
using BlogN.Models;

namespace BlogN.Data.Repositories.Repository
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        private ApplicationDbContext _context;
        public ArticleRepository(ApplicationDbContext context): base(context)   
        {
            _context = context;

        }
    }
}
