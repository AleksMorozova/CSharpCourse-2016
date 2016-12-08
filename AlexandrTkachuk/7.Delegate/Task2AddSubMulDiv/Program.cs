using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2AddSubMulDiv
{
    delegate double CalculatorDel(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sign of operation: ");
            char operationSign = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double result = CalculateResult(num1, num2, operationSign);
            Console.WriteLine("{0} {1} {2} = {3}", num1, operationSign, num2, result);
        }

        static double CalculateResult(int num1, int num2, char operationSign)
        { 
            double result;
            switch (operationSign)
            { 
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Sub(num1, num2);
                    break;
                case '*':
                    result = Mul(num1, num2);
                    break;
                case '/':
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Error! You chose wrong sign");
                    result = 0;
                    break;
            }
            return result;
        } 

        static CalculatorDel Add = (num1, num2) => { return num1 + num2; };

        static CalculatorDel Sub = (num1, num2) => { return num1 - num2; };

        static CalculatorDel Mul = (num1, num2) => { return num1 * num2; };

        static CalculatorDel Div = (num1, num2) =>
        {
            if (num2 != 0)
            {
                return (double)num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed");
                return 0;
            };
        };

    }
}
