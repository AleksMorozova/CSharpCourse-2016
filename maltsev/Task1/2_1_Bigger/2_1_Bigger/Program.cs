using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_1_Bigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Большее число: {0}",(a>b)? a : b);
            Console.ReadKey();
        }
    }
}
