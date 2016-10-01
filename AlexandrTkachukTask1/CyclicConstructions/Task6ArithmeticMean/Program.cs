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
            Random r = new Random();
            int sum = 0;
            int[] arr = { r.Next(0, 50), r.Next(0, 50), r.Next(0, 50), r.Next(0, 50), r.Next(0, 50) };
            Console.Write("Созданы числа : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое этих чисел : " + (double)sum / arr.Length);
        }
    }
}
