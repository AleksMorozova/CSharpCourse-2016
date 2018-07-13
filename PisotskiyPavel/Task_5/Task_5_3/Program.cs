using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = NumbersGenerator(10, -100, 100);

            Console.WriteLine("До сортировки: ");
            Print(array);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("После сортировки по возрастанию: ");
            Print(array.Sort());

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("После сортировки по убыванию: ");
            Print(array.Sort(false));

            Console.ReadLine();
        }

        static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(" ,");
                }
            }
        }

        static int[] NumbersGenerator(int arraySize, int minValue, int maxValue)
        {
            int[] array = new int[arraySize];
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }

            return array;
        }
    }
}
