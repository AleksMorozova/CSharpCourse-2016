using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int unknownNumber = r.Next(1, 147);
            int number = 0;
            Console.WriteLine("Загадано число от 1 до 146, попытайтесь угадать");
            do
            {
                Console.Write("Введите число : ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number < unknownNumber)
                {
                    Console.WriteLine("Больше");
                }
                if (number > unknownNumber)
                {
                    Console.WriteLine("Меньше");
                }
            }
            while (number != unknownNumber);
            Console.WriteLine("Вы угадали! Загаданное число : " + unknownNumber);
        }
    }
}
