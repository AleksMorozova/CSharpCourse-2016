using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_5_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 любых чисел:");
            double[] numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Введите число №{0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Среднее арифметическое этих чисел: {0}", Average(numbers));

            Console.ReadLine();
        }

        static double Average(ICollection<double> numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                checked
                {
                    sum += number;
                }
            }

            return sum / numbers.Count;
        }
    }
}
