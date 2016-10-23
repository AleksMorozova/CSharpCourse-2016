using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4TheSquaresOfTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Числа, квадраты которых меньше, чем " + number + " : ");
            for (int i = 1; i < number; i++)
            {
                if (i * i < number)
                {
                    Console.Write(i + "(" + i * i + ")   ");
                }
            }

        }
    }
}
