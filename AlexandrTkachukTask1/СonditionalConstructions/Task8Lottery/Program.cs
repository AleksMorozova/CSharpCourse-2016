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
            Random r = new Random();
            int num;
            Console.WriteLine("Условия лотереи : ");
            Console.WriteLine("Если выпадают значениея от 1 до 5, то вы проиграли.");
            Console.WriteLine("Если выпадают значениея от 6 до 8, то вы получаете ставку обратно.");
            Console.WriteLine("Если выпадают значениея от 9 до 11, то ваша ставка удваивается.");
            Console.WriteLine("Если выпадает 12, то ваша ставка увеличивается в 10 раз.");
            Console.WriteLine();
            Console.Write("Сделайте ставку : ");
            int bet = Convert.ToInt32(Console.ReadLine());            
            for (; ; )
            {
                Console.WriteLine();
                num = r.Next(1, 13);
                if (num >= 1 && num <= 5)
                {
                    Console.WriteLine("Выпало число : " + num + " Вы проиграли");
                    Console.WriteLine("Игра закончена");
                    return;
                }
                else if (num >= 6 && num <= 8)
                {
                    Console.WriteLine("Выпало число : " + num + " Вы получаете вашу ставку обратно");
                }
                else if (num >= 9 && num <= 11)
                {
                    Console.WriteLine("Выпало число : " + num + " Ваша ставка удваивается");
                    bet *= 2;
                }
                else
                {
                    Console.WriteLine("Выпало число : " + num + " Ваша ставка ставка увеличивается в 10 раз!!!");
                    bet *= 10;
                }
                if (bet != 0)
                {
                    Console.WriteLine("Ваша ставка равна : " + bet);
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
