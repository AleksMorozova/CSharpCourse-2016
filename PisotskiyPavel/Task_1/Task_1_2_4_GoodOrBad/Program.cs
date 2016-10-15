using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_4_GoodOrBad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 или 0:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number == 1 ? "Хорошо" : "Плохо");

            Console.ReadLine();
        }
    }
}
