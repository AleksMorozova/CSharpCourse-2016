using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_2_NumberRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество разрядов числа {0}: {1}", number, GetRange(number));
            Console.ReadLine();
        }

        static int GetRange(int number)
        {
            number = Math.Abs(number);
            int range = (number == 0) ? 1 : 0;
            while (number > 0)
            {
                number = number / 10;
                range++;
            }

            return range;
        }
    }
}
