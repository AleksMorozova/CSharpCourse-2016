using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_Password
{
    class Auth : IAuth
    {
        private const string password = "root";
        public bool GetAccess(string pass)
        {
            return pass == password;
        }
    }
}
