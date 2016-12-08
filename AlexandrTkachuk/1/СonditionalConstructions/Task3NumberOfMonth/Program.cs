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
            int numberOfMonth = Convert.ToInt32(Console.ReadLine());
            if (numberOfMonth == 1 || numberOfMonth == 2 || numberOfMonth == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (numberOfMonth == 3 || numberOfMonth == 4 || numberOfMonth == 5)
            {
                Console.WriteLine("Весна");
            }
            else if (numberOfMonth == 6 || numberOfMonth == 7 || numberOfMonth == 8)
            {
                Console.WriteLine("Лето");
            }
            else if (numberOfMonth == 9 || numberOfMonth == 10 || numberOfMonth == 11)
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
