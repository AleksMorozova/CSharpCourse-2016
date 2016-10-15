using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_8_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "root";
            string password = string.Empty;

            do
            {
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                Console.Clear();
                if (!correctPassword.Equals(password))
                {
                    Console.WriteLine("Неверный пароль!");
                }
            } while (!correctPassword.Equals(password));

            Console.WriteLine("Вы успешно ввели пароль.");

            Console.ReadLine();
        }
    }
}
