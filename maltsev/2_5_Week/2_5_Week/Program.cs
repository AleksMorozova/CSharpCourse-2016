using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число (1,...,7): ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.Write("Понедельник"); break;
                case 2: Console.Write("Вторник"); break;
                case 3: Console.Write("Среда"); break;
                case 4: Console.Write("Четверг"); break;
                case 5: Console.Write("Пятница"); break;
                case 6: Console.Write("Суббота"); break;
                case 7: Console.Write("Воскресенье"); break;
                default: Console.Write("Такого дня недели не существует"); break;
            }
            Console.ReadKey();
        }
    }
}
