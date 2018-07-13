using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_3_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int unknownNumber = GenerateRandomNumber(1, 146);
            Console.WriteLine(unknownNumber);
            int number;
            do
            {
                Console.Write("Угадайте число от 1 до 146: ");
                number = Convert.ToInt32(Console.ReadLine());
                if(number != unknownNumber)
                {
                    if(unknownNumber > number)
                    {
                        Console.WriteLine("Больше!!!");
                    }
                    else
                    {
                        Console.WriteLine("Меньше!!!");
                    }
                }

            } while (number != unknownNumber);

            Console.WriteLine("Поздравляю, Вы угадали");

            Console.ReadLine();
        }
        
        static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            return random.Next(min, max + 1);
        }
    }
}
