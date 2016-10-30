using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2SortExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 3, 8, 10, 2, 5, 1 };
            ShowArray(array);
            array.SortArrayByIncrease();
            Console.WriteLine("Sorted array: ");
            ShowArray(array);
           
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
