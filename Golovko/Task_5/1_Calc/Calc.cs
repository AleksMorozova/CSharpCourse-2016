using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Calc
{
    static class Calc
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double Defference(double a, double b)
        {
            return a - b;
        }
        public static double Opposite(double a)
        {
            return -a;
        }
        public static double Composition(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// Quotient calclation
        /// </summary>
        /// <param name="a">devidend</param>
        /// <param name="b">devider</param>
        /// <returns>quotient</returns>
        public static double Quotient(double a, double b)
        {
            double result;
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                result = double.PositiveInfinity;
                Console.WriteLine(e.Message);

            }
            return result;
        }
        public static double Percent(double a)
        {
            return a / 100;
        }
        public static double Reciproc(double a)
        {            
            return 1 / a;
        }
        public static double Sqrt(double x)
        {
            return GeronSqrt(x, 1);
        }
        /// <summary>
        /// Implemintation of Geron method for Sqrt function
        /// </summary>
        /// <param name="x">argument</param>
        /// <param name="a">hypothesis first argument (x0)</param>
        /// <returns>hypothetic value of Sqrt with some deviation</returns>
        private static double GeronSqrt(double x, double a)
        {
            double xn;
            if (x < 0)
            {
                return double.NaN;
            }
            if ((xn = (a + x / a) / 2) - a == 0)
            {
                return xn;
            }
            return GeronSqrt(x, xn);
        }
        public static double Pow(double a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * Pow(a, --b);
        }
    }
}
