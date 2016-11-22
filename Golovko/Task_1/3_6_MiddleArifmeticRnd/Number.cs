using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_MiddleArifmeticRnd
{
    class Number : INumber
    {
        private readonly int[] numbers;
        public Number(int min, int max, int count)
        {
            numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Generator.Generate(min, max);
                Console.WriteLine("Generate number[{0}] = {1}", i + 1, numbers[i]);
            }
        }
        public decimal GetMiddleArifmetic()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return Math.Round((decimal)sum / numbers.Length, 2);
        }
    }
}
