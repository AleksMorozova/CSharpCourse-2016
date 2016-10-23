using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7IsDigitSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = number / 2; i > 1; i--)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Число " + number + " не простое");
                    return;
                }

            }
            Console.WriteLine("Число " + number + " простое");
        }
    }
}
