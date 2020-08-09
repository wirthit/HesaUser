using System;
using System.ComponentModel.DataAnnotations;

namespace MvcUser.Data
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
}
