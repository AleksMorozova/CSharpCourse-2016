using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5UsersArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Введите " + (i + 1) + "-е число : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                sum += numbers[i];
            }
            Console.WriteLine("Среднее арифметическое этих чисел : " + (double)sum / numbers.Length);
        }
    }
}
