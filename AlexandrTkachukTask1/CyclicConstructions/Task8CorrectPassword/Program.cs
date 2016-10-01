using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8CorrectPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "root";
            Console.Write("Введите пароль : ");
            string str = Console.ReadLine();
            while (str != password)
            {
                Console.Write("Неверный пароль. Попробуйте еще раз : ");
                str = Console.ReadLine();
            }
            Console.WriteLine("Верный пароль!");
        }
    }
}
