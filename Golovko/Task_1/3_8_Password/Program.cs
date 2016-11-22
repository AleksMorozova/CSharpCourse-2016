using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            IAuth auth = new Auth();
            Console.WriteLine("Enter the password:");
            while (!auth.GetAccess(Console.ReadLine()))
            {
                Console.WriteLine("Access denied. Wrong Password. Try again.");
            }
            Console.WriteLine("Welcome to system!");
            Console.ReadKey();
        }
    }
}
