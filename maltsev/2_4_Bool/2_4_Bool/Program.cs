using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_4_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Число (1/0): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", (a == 1)? "Хорошо" : "Плохо");
            Console.ReadKey();
        }
    }
}
