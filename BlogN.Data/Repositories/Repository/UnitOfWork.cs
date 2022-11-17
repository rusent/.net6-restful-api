using BlogN.Data.Repositories.IRepository;
using BlogN.SharedTools;
using Microsoft.Extensions.Options;

namespace BlogN.Data.Repositories.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private readonly IOptions<AppSettings> _appSettings;

        public UnitOfWork(ApplicationDbContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings;
        }
        public ICategoryRepository Category => new CategoryRepository(_context);
        public IArticleRepository Article => new ArticleRepository(_context);
        public IUserRepository User => new UserRepository(_context, _appSettings);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
