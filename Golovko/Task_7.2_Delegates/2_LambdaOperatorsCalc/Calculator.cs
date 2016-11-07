using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LambdaOperatorsCalc
{
    static class Calculator
    {
        public static CalcDelegate Add = (a, b) => a + b;
        public static CalcDelegate Sub = (a, b) => a - b;
        public static CalcDelegate Mul = (a, b) => a * b;
        public static CalcDelegate Div = (a, b) =>
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero exception. {0}", e.Message);
                return a < 0 ? double.NegativeInfinity : double.PositiveInfinity;
            }
        };
    }
}
