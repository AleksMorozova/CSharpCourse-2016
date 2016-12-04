using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_2
{
    class Program
    {
        static Func<double, double, double> Add = (a, b) => a + b;
        static Func<double, double, double> Sub = (a, b) => a - b;
        static Func<double, double, double> Mul = (a, b) => a * b;
        static Func<double, double, double> Div = (a, b) =>
        {
            if(b == 0)
            {
                Console.WriteLine("Ошибка деления на 0.");
                return 0;
            }

            return a / b;
        };

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию над числами(+, -, *, /): ");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}", a, b, Add(a, b));
                    break;

                case "-":
                    Console.WriteLine("{0} - {1} = {2}", a, b, Sub(a, b));
                    break;

                case "*":
                    Console.WriteLine("{0} * {1} = {2}", a, b, Mul(a, b));
                    break;

                case "/":
                    Console.WriteLine("{0} / {1} = {2}", a, b, Div(a, b));
                    break;

                default:
                    Console.WriteLine("Данная операция не поддерживается");
                    break;
            }

            Console.ReadLine();
        }
    }
}
