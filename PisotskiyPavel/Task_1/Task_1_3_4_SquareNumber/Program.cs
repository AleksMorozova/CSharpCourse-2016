using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_4_SquareNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадраты натуральных чисел, которые меньше числа {0}:", number);
            foreach (int square in GetSquares(number))
            {
                Console.WriteLine(square);
            }

            Console.ReadLine();
        }

        static IEnumerable<int> GetSquares(int number)
        {
            List<int> squares = new List<int>();

            for (int i = 1; i < Math.Sqrt(number); i++)
            {
                int square = (int)Math.Pow(i, 2);
                squares.Add(square);
            }

            return squares;
        }
    }
}
