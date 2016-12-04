using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для определения факториала: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                int factorial = Factorial(number);
                Console.WriteLine($"{number}! = {factorial}");
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadLine();
        }

        static int Factorial(int number)
        {
            if (number < 0)
                throw new NegativeNumberException("Negative number not permitted.");

            int factorial = 1;

            if (number == 0)
                return factorial;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
