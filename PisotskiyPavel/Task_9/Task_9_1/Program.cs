using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, -5, 4, 8, 7, 3, 10 };
            foreach (int number in GetEvenNumbers(numbers))
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        static IEnumerable<int> GetEvenNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    yield return numbers[i];
            }
        }
    }
}
