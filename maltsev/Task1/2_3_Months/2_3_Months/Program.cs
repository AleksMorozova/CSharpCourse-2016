using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_3_Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Номер месяца: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1 || a == 2 || a == 12)
                Console.WriteLine("Зима");
            else if (a > 2 && a < 6)
                Console.WriteLine("Весна");
            else if (a > 5 && a < 9 )
                Console.WriteLine("Лето");
            else if (a > 8 && a < 12 )
                Console.WriteLine("Осень");
            else Console.WriteLine("На этой планете такого месяца нет");
            Console.ReadKey();
        }
    }
}
