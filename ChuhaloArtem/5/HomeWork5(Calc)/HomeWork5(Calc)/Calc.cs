using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Calc_
{
    static class Calc
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Sub(double a, double b)
        {
            return a - b;
        }

        public static double Mul(double a, double b)
        {
            return a * b;
        }

        public static double Div(double a, double b)
        {
            double result = a / b; ;
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }                
            }
            catch (DivideByZeroException e)
            {               
                Console.WriteLine(e.Message);
            }
            return result;
        }

        public static double Pow(double a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * Pow(a, --b);
        }

        public static double Percent(double a)
        {
            return a / 100;
        }

    }
}
