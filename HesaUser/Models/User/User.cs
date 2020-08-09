using System;
using System.ComponentModel.DataAnnotations;

namespace MvcUser.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Started { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? Left { get; set; }
    }
}
