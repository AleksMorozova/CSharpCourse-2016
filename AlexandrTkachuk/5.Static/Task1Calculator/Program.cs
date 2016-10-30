using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый опренд: ");
            double enteredNumber1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите знак операции (+, -, *, /): ");
            char operationSign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите второй опренд: ");
            double enteredNumber2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1} {2} = {3}", enteredNumber1, operationSign, enteredNumber2,
                CallRequiredOperation(operationSign, enteredNumber1, enteredNumber2));
        }

        public static double CallRequiredOperation(char operationSign, double enteredNumber1, double enteredNumber2)
        {
            double result = 0;
            switch (operationSign)
            { 
                case '+':
                    result = Calculator.Add(enteredNumber1, enteredNumber2);
                    break;
                case '-':
                    result = Calculator.Subtract(enteredNumber1, enteredNumber2);
                    break;
                case '/':
                    result = Calculator.Divide(enteredNumber1, enteredNumber2);
                    break;
                case '*':
                    result = Calculator.Multiply(enteredNumber1, enteredNumber2);
                    break;
                default:
                    Console.WriteLine("Неверный знак операции!");
                    Environment.Exit(1);
                    break;
            }
            return result;        
        }
    }
}
