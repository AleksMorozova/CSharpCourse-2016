using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_2_Ranks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            Console.Write("У числа {0} разрядов.", count);
            Console.ReadKey();
        }
    }
}
