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
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите " + (i + 1) + "-е число : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                sum += arr[i];
            }
            Console.WriteLine("Среднее арифметическое этих чисел : " + (double)sum / arr.Length);
        }
    }
}
