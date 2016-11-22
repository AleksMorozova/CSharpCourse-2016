using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_7_legs
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            do
            {
                j = (64 - i * 2) / 4;
                Console.WriteLine("Кроликов - {0}, гусей {1}", j, i);
                i += 2;
            } while (i * 2 != 64);
            Console.ReadKey();
        }
    }
}
