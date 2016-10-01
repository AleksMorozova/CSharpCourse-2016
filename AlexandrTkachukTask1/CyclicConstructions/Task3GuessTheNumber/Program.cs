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
            int unknownNum = r.Next(1, 147);
            int num = 0;
            Console.WriteLine("Загадано число от 1 до 146, попытайтесь угадать");
            do
            {
                Console.Write("Введите число : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < unknownNum)
                {
                    Console.WriteLine("Больше");
                }
                if (num > unknownNum)
                {
                    Console.WriteLine("Меньше");
                }
            }
            while (num != unknownNum);
            Console.WriteLine("Вы угадали! Загаданное число : " + unknownNum);
        }
    }
}
