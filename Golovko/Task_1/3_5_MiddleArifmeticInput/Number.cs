using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_MiddleArifmeticInput
{
    class Number : INumber
    {
        private readonly int[] numbers;
        public Number(int[] numbers)
        {
            this.numbers = numbers;
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
