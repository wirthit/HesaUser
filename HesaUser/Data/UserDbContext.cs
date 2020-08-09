using MvcUser.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcUser.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) // for migration
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
