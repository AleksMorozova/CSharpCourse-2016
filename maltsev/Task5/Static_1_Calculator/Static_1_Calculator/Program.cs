using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_1_Calculator
{
    static class Calculator
    {
        static public double Add(double a, double b)
        {
            return a + b;
        }
        static public double Subtract(double a, double b)
        {
            return a - b;
        }
        static public double Multiply(double a, double b)
        {
            return a * b;
        }
        static public double Divide(double a, double b)
        {
            return a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator.Add(2, 8)\t\t" + Calculator.Add(2, 8));
            Console.WriteLine("Calculator.Subtract(40, 1)\t" + Calculator.Subtract(40, 1));
            Console.WriteLine("Calculator.Multiply(3, 10)\t" + Calculator.Multiply(3, 10));
            Console.WriteLine("Calculator.Divide(60, 20)\t" + Calculator.Divide(60, 20));

            Console.ReadKey();
        }
    }
}
