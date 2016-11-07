using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LambdaOperatorsCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(2, 3));
            Console.WriteLine(Calculator.Sub(2, 3));
            Console.WriteLine(Calculator.Mul(2, 3));
            Console.WriteLine(Calculator.Div(2, 3));
            Console.WriteLine(Calculator.Div(2, 0));
            Console.ReadKey();
        }
    }
}
