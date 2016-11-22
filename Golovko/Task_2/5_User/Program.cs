using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("mrSmile", "Gregory", "Golovko", 29);
            user.PrintInfo();
            Console.ReadKey();
        }
    }
}
