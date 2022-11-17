using BlogN.Models;

namespace BlogN.Data.Repositories.IRepository
{
    public interface IUserRepository 
    {
        bool IsUniqueUser(string username);
        User Authenticate(string username, string password);
        User Register(string username, string password);
    }
}
