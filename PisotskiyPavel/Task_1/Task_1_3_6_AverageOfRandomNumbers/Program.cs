using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_6_AverageOfRandomNumbers
{
    class Program
    {
        static Random random = new Random((int)DateTime.Now.Ticks);

        static void Main(string[] args)
        {
            Console.WriteLine("Числа:");
            double[] numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
                Console.WriteLine(numbers[i]);
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
