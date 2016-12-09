using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Task2_
{
    class Operation
    {
        public static IntOperation Add = (a, b) => Console.WriteLine("A + B = {0}", a + b);
        public static IntOperation Sub = (a, b) => Console.WriteLine("A - B = {0}", a - b);
        public static IntOperation Mul = (a, b) => Console.WriteLine("A * B = {0}", a * b);
        public static IntOperation Div = (a, b) =>
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine("A / B = {0}", a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero exception. {0}", e.Message);
            }
        };
    }
}
