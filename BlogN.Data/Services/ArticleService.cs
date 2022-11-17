using BlogN.Data.Repositories.IRepository;
using BlogN.Data.Services.IService;
using BlogN.Models;

namespace BlogN.Data.Services
{
    public class ArticleService : Services<Article>, IArticleService
    {
        public ArticleService(IUnitOfWork unitOfWork, IRepository<Article> repository) : base(unitOfWork, repository)
        {
        }
    }
}
