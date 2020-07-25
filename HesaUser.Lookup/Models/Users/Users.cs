using System.Collections.Generic;

namespace HesaUser.Lookup.Models
{
    public class Users
    {
        public string filter = string.Empty;
        public List<User> UserList { get; set; }
    }
}
