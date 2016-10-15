using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_DisplayFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFullName("Писоцкий Павел Александрович");
            Console.ReadLine();
        }

        static void DisplayFullName(string fullName)
        {
            Console.WriteLine("+{0}+", new string('-', fullName.Length));
            Console.WriteLine("|{0}|", fullName);
            Console.WriteLine("+{0}+", new string('-', fullName.Length));
        }
    }
}
