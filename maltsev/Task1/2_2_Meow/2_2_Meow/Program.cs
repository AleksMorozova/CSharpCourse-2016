using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_2_Meow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Слово:");
            string s = Console.ReadLine();
            if (s == "мяу")
                Console.WriteLine("Покорми кота");
            else if (s == "гав")
                Console.WriteLine("Погуляй с собакой");
            else Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
