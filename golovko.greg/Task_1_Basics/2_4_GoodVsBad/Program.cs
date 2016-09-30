using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_GoodVsBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 - Good or 0 - Bad:");
            Console.WriteLine(Convert.ToByte(Console.ReadLine()) == 1 ? "Good" : "Bad");
            Console.ReadKey();
        }
    }
}
