using BlogN.Models;

namespace BlogN.Data.Services.IService
{
    public interface IUserService
    {
        bool IsUniqueUser(string username);
        User Authenticate(string username, string password);
        User Register(string username, string password);
    }
}
