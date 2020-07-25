using HesaUser.Data;
using Microsoft.EntityFrameworkCore;

namespace HesaUser
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) // for migration
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
