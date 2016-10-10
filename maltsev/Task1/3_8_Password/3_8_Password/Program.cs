using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_8_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pas = "";
            bool flag =true;
            while (flag)
            {
                Console.Write("Введите пароль: ");
                pas = Console.ReadLine();
                if (pas == "root")
                {
                    Console.WriteLine("Пароль принят.");
                    flag = false;
                }
                else Console.WriteLine("Пароль неверный!");
            }
            Console.ReadKey();
        }
    }
}
