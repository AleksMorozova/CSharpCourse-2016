using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.Composition(10, 20));
            Console.WriteLine(Calc.Defference(25, 5));
            Console.WriteLine(Calc.Opposite(100));
            Console.WriteLine(Calc.Percent(15));
            Console.WriteLine(Calc.Quotient(50, 10));
            Console.WriteLine(Calc.Reciproc(10));
            Console.WriteLine(Calc.Sum(199, 1));
            Console.WriteLine(Calc.Sqrt(625));
            Console.WriteLine(Calc.Pow(2, 8));
            Console.WriteLine(Calc.Abs(-50));
            Console.ReadKey();
        }
    }
}
