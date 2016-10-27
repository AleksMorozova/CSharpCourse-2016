using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstValue = GetNumber("Введите первое значение: ");
                double secondValue = GetNumber("Введите второе значение: ");
                Console.Write("Выберите операцию над числами (+, -, *, /): ");
                string symbol = Console.ReadLine();
                Console.Clear();
                Calculate(firstValue, secondValue, symbol);
                Console.WriteLine();
            }
        }

        static double GetNumber(string message)
        {
            Console.Write(message);
            double result;
            if (!double.TryParse(Console.ReadLine(), out result))
            {
                result = GetNumber(message);
            }
            return result;
        }

        static void Calculate(double firstValue, double secondValue, string operation)
        {
            switch (operation.Trim())
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", firstValue, secondValue, Calculator.Add(firstValue, secondValue));
                    break;

                case "-":
                    Console.WriteLine("{0} - {1} = {2}", firstValue, secondValue, Calculator.Subtract(firstValue, secondValue));
                    break;

                case "*":
                    Console.WriteLine("{0} * {1} = {2}", firstValue, secondValue, Calculator.Multiply(firstValue, secondValue));
                    break;

                case "/":
                    {
                        try
                        {
                            Console.WriteLine("{0} / {1} = {2}", firstValue, secondValue, Calculator.Divide(firstValue, secondValue));
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Данная операция не поддерживается!");
                    break;
            }
        }
    }
}
