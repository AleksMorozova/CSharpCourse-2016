using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3NumberOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер месяца : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1 || num == 2 || num == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (num == 3 || num == 4 || num == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (num == 6 || num == 7 || num == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (num == 9 || num == 10 || num == 11)
            {
                Console.WriteLine("Осень");
            }
            else
            {
                Console.WriteLine("На этой планете такого месяца нет");
            }
        }
    }
}
