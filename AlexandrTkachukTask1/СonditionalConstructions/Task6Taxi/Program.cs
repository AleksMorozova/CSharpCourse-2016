using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество километров : ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество минут простоя : ");
            int min = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (km <= 5)
            {
                result = 20 + min;
                Console.WriteLine("Вы должны заплатить: " + result + "грн");
            }
            else
            {
                result = 20 + (km - 5) * 3 + min;
                Console.WriteLine("Вы должны заплатить: " + result + "грн");
            }
        }
    }
}
