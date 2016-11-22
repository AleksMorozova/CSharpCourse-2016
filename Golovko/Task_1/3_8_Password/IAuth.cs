using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_Password
{
    interface IAuth
    {
        bool GetAccess(string pass);
    }
}
