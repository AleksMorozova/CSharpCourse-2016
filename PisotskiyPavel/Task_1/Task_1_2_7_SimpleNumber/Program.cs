using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_7_SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (IsSimple(number))
            {
                Console.WriteLine("Число {0} - является простым.", number);
            }
            else
            {
                Console.WriteLine("Число {0} - не является простым.", number);
            }
            Console.ReadLine();
        }

        static bool IsSimple(int number)
        {
            int numberOfDivisors = 0;

            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0)
                {
                    numberOfDivisors++;
                }
            }

            return numberOfDivisors == 2;
        }
    }
}
