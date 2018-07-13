using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_8_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сделайте вашу ставку: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы выиграли {0} грн.", CalculateWinnings(rate));

            Console.ReadLine();
        }

        static double CalculateWinnings(double rate)
        {
            double winning = 0;
            int result = ThrowDice(12);

            if (result >= 6 && result <= 8)
            {
                winning = rate;
            }
            else if(result >= 9 && result <= 11)
            {
                winning = rate * 2;
            }
            else if(result == 12)
            {
                winning = rate * 10;
            }


            return winning;
        }


        static Random random = new Random((int)DateTime.Now.Ticks);

        static int ThrowDice(int numberOfSides)
        {
            return random.Next(1, numberOfSides + 1);
        }
    }
}
