using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_3
{
    class Program
    {
        delegate double AverageDelegate(Func<int>[] numbers);
        static AverageDelegate Average = (numbers) =>
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[0].Invoke();
            }

            return sum / (double)numbers.Length;
        };

        static Random random = new Random();

        static void Main(string[] args)
        {
            Func<int> number = () => random.Next();
            Func<int>[] numbers = new Func<int>[]
            {
                number,
                number,
                number,
                number,
                number,
                number
            };

            Console.WriteLine(Average(numbers));

            Console.ReadLine();

        }
    }
}
