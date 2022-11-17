using BlogN.Data.Repositories.IRepository;
using BlogN.Data.Services.IService;
using System.Linq.Expressions;

namespace BlogN.Data.Services
{
    public class Services<T> : IService<T> where T : class
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;

        public Services(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<bool> Add(T entity)
        {
            await _repository.Add(entity);
            await _unitOfWork.SaveAsync();
            return true;
        }

        public bool Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.Save();
            return true;
        }

        public async Task<T> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            return await _repository.GetAll(filter, orderBy, includeProperties);    
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            return await _repository.GetFirstOrDefault(filter, includeProperties);
        }

        public T Update(T entity)
        {
            var newEntity = _repository.Update(entity);
            _unitOfWork.Save();
            return newEntity; 
        }
    }
}
