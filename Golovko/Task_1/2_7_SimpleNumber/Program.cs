using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter natural number, please:");
            int number = int.Parse(Console.ReadLine());
            INaturalNumber natNumber = new NaturalNumber(number);
            Console.WriteLine(natNumber.IsSimple() ? "The number is simple" : "The number isn't simple");
            Console.ReadLine();
        }
    }
}
