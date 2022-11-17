using BlogN.Data.Repositories.IRepository;
using BlogN.Data.Services.IService;
using BlogN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogN.Data.Services
{
    public class CategoryService : Services<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }
    }
}
