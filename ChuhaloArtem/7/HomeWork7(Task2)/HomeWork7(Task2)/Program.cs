using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Task2_
{
    delegate void IntOperation(double i, double j);

    class Program
    {
        static void Main(string[] args)
        {
            string choise;
            double first, second;

            Console.WriteLine("Select first operand: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select second operand: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose operation (add, sub, mul, div): ");
            choise = Console.ReadLine();

            switch(choise)
            {
                case "add":
                    Operation.Add(first, second);
                    break;

                case "sub":
                    Operation.Sub(first, second);
                    break;

                case "mul":
                    Operation.Mul(first, second);
                    break;

                case "div":
                    Operation.Div(first, second);
                    break;

                default: Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
        }
    }
}
