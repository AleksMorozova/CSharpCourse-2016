using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6ArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            int[] numbers = { random.Next(0, 50), random.Next(0, 50), random.Next(0, 50), random.Next(0, 50), random.Next(0, 50) };
            Console.Write("Созданы числа : ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                sum += numbers[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое этих чисел : " + (double)sum / numbers.Length);
        }
    }
}
