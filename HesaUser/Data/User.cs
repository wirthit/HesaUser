using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HesaUser.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime Started { get; set; }
        public DateTime Left { get; set; }
    }

    public class UserDbContext : DbContext
    {
        //private DbContextOptionsBuilder options;

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) // for migration
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
