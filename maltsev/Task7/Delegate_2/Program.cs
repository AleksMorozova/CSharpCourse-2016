using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Add= ((a, b) => a + b);
            Func<int, int, int> Sub = ((a, b) => a - b);
            Func<int, int, int> Mul = ((a, b) => a * b);
            Func<int, int, double> Div = ((a, b) =>
            {
                try
                {
                    double c = a / b;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
                return (double)a / (double)b;
            }); 

            Console.WriteLine("{0:#.##}", Add(5, 6));
            Console.WriteLine("{0:#.##}", Sub(5, 6));
            Console.WriteLine("{0:#.##}", Mul(5, 6));
            Console.WriteLine("{0:#.##}", Div(50, 6));
            Console.WriteLine("{0:#.##}", Div(5, 0));

            Console.ReadKey();

        }
    }
}
