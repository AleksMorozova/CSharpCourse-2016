using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_1_Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
                Console.WriteLine("{0}*{1}\t{2}", i, a, a * i);
            Console.ReadKey();
        }
    }
}
