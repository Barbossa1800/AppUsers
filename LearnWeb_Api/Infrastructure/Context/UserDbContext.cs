using LearnWeb_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnWeb_Api.Infrastructure.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users{ get; set; }
    }
}
