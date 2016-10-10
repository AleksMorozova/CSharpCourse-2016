using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_6_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество километров: ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество минут простоя: ");
            int pr = Convert.ToInt32(Console.ReadLine());
            int value = 0;
            if (km > 5)
            {
                km -= 5;
                value = 5*20 + km*3 + pr;
                Console.Write("Стоимость: {0}", value);
            }
            else
            {
                value = km * 20 + pr;
                Console.Write("Стоимость: {0} грн", value);
            }
            Console.ReadKey();
        }
    }
}
