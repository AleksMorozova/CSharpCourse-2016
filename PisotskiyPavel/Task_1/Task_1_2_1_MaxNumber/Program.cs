using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_1_MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = GetNumber("Введите первое число:");
            double secondNumber = GetNumber("Введите второе число:");

            double maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.WriteLine("Максимально число: {0}", maxNumber);

            Console.ReadLine();
        }

        static double GetNumber(string message)
        {
            Console.WriteLine(message);
            double result;
            if(!double.TryParse(Console.ReadLine(), out result))
            {
                result = GetNumber(message);
            }
            return result;
        }
    }
}
