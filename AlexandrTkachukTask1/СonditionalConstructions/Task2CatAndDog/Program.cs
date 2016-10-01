using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2CatAndDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово : ");
            string word = Console.ReadLine();
            if (word == "мяу")
            {
                Console.WriteLine("Покорми кота");
            }
            else if (word == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else
            {
                Console.WriteLine("Введено неправильное слово");
            }
        }
    }
}
