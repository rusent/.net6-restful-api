using BlogN.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogN.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } 
        public DbSet<Article> Articles { get; set; } 
        public DbSet<User> Users { get; set; } 
    }
}
