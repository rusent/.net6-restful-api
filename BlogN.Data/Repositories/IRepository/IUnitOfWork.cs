namespace BlogN.Data.Repositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IArticleRepository Article { get; }
        IUserRepository User { get; }
        Task SaveAsync();
        void Save();
    }
}
