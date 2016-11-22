using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_4_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число N: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int square = 0, number = 1;
            bool flag = true;
            while (flag)
            {
                square = number * number;
                if (square > a) flag = false;
                else
                {
                    Console.WriteLine("{0}", square);
                    number++;
                }
            }
            Console.ReadKey();
        }
    }
}
