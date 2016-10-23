using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowLotteryConditions();           
            Console.Write("Сделайте ставку : ");
            int bet = Convert.ToInt32(Console.ReadLine());
            Lottery(bet);
        }
        static void ShowLotteryConditions()
        {
            Console.WriteLine("Условия лотереи : ");
            Console.WriteLine("Если выпадают значениея от 1 до 5, то вы проиграли.");
            Console.WriteLine("Если выпадают значениея от 6 до 8, то вы получаете ставку обратно.");
            Console.WriteLine("Если выпадают значениея от 9 до 11, то ваша ставка удваивается.");
            Console.WriteLine("Если выпадает 12, то ваша ставка увеличивается в 10 раз.");
            Console.WriteLine();
        }

        static void Lottery(int bet)
        {
            Random random = new Random();
            int numberOnCube;
            for (; ; )
            {
                Console.WriteLine();
                numberOnCube = random.Next(1, 13);
                if (numberOnCube >= 1 && numberOnCube <= 5)
                {
                    Console.WriteLine("Выпало число " + numberOnCube + ". Вы проиграли");
                    Console.WriteLine("Игра закончена");
                    return;
                }
                else if (numberOnCube >= 6 && numberOnCube <= 8)
                {
                    Console.WriteLine("Выпало число " + numberOnCube + ". Вы получаете вашу ставку обратно");
                }
                else if (numberOnCube >= 9 && numberOnCube <= 11)
                {
                    Console.WriteLine("Выпало число " + numberOnCube + ". Ваша ставка удваивается");
                    bet *= 2;
                }
                else
                {
                    Console.WriteLine("Выпало число " + numberOnCube + ". Ваша ставка ставка увеличивается в 10 раз!!!");
                    bet *= 10;
                }
                if (bet != 0)
                {
                    Console.WriteLine("Ваша ставка равна " + bet);
                    Console.Write("Вы хотите играть дальше?. Если хотите, то введите слово \"да\", если не хотите, то нажмите любую кнопку : ");
                    if (Console.ReadLine() != "да")
                    {
                        Console.WriteLine("Игра закончена");
                        Console.ReadKey();
                        return;
                    }
                }
            }
        }
    }
}
