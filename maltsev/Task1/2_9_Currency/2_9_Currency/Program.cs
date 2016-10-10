using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_9_Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сумма: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вид валюты: ");
            Console.WriteLine("1. Гривны");
            Console.WriteLine("2. Доллары");
            Console.WriteLine("3. Евро");
            int val = Convert.ToInt32(Console.ReadLine());
            double DolToHrn = 25.911879;
            double EurToHrn = 29.075720;
            if (val == 1)
            {
                Console.WriteLine("{0} гривен", a);
                Console.WriteLine("{0:f2} долларов", a / DolToHrn);
                Console.WriteLine("{0:f2} евро", a/EurToHrn);
            }
            else if (val == 2)
            {
                Console.WriteLine("{0:f2} гривен", a * DolToHrn);
                Console.WriteLine("{0} долларов", a );
                Console.WriteLine("{0:f2} eвро", a * DolToHrn / EurToHrn);
            }
            else if (val == 3)
            {
                Console.WriteLine("{0:f2} гривен", a * EurToHrn);
                Console.WriteLine("{0:f2} долларов", a * EurToHrn / DolToHrn);
                Console.WriteLine("{0} евро", a );
            }
            else Console.WriteLine("Ошибка");
            Console.ReadKey();
        }
    }
}
