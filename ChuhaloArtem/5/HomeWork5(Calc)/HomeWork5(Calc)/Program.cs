using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Calc_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a + b = {0}", Calc.Sum(23, 46));
            Console.WriteLine("a - b = {0}", Calc.Sub(23, 46));
            Console.WriteLine("a * b = {0}", Calc.Mul(23, 46));
            Console.WriteLine("a / b = {0}", Calc.Div(23, 46));
            Console.WriteLine("a % = {0}", Calc.Percent(78));
            Console.WriteLine("a ^ b = {0}", Calc.Pow(23, 4));
            Console.ReadKey();
        }
    }
}
