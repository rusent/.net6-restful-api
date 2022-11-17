using BlogN.Data.Repositories.IRepository;
using BlogN.Data.Services.IService;
using BlogN.Models;

namespace BlogN.Data.Services
{
    public class UserService : IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _repository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository repository) 
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public User Authenticate(string username, string password)
        {
            var user = _repository.Authenticate(username, password);
            return user;
        }

        public bool IsUniqueUser(string username)
        {
            return _repository.IsUniqueUser(username); 
        }

        public User Register(string username, string password)
        {
            var user = _repository.Register(username, password);
            _unitOfWork.Save();
            return user;

        }
    }
}
