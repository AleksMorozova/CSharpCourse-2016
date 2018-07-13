using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_2_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите \"Мяу\" или \"Гав\":");
            string word = Console.ReadLine().ToLower();
            string result = string.Empty;
            if (word.Equals("мяу"))
            {
                result = "Покорми кота";
            }
            else if (word.Equals("гав"))
            {
                result = "Погуляй с собакой";
            }
            else
            {
                result = "Вы ввели не корректное слово.";
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
