using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_MiddleArifmeticInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of numbers:");
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
                numbers[i] = int.Parse(Console.ReadLine());
            INumber number = new Number(numbers);
            Console.WriteLine("Middle arifmetic is {0}", number.GetMiddleArifmetic());
            Console.ReadKey();
        }
    }
}
