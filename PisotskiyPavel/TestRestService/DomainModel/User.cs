using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<string> Tokens { get; set; }
        public List<Role> Roles { get; set; }

        public User()
        {
            Tokens = new List<string>();
            Roles = new List<Role>();
        }
    }
}
