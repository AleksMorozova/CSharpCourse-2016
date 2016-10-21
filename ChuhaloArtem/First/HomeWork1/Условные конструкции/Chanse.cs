using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Chanse
    {
        public void Function()
        {
            Random realrnd = new Random();
            string y="n";
            int bounse;

            Console.Write("\nEnter your start money: ");
            int money=Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("\nСделайте ставку (у вас {0} очков): ", money);
                int step = Convert.ToInt32(Console.ReadLine());
                bounse = realrnd.Next(1, 12);
                Console.WriteLine("На кубике: {0}", bounse);
                if(bounse<=5 && bounse>=1)
                {
                    money = money - step;
                    Console.WriteLine("Вы проиграли.");
                }
                if (bounse <= 8 && bounse >= 6)
                {
                    Console.WriteLine("Вы получаете ставку назад.");
                }
                if (bounse <= 11 && bounse >= 9)
                {
                    money = money + step;
                    Console.WriteLine("Вы удвоили свою ставку.");
                }
                if (bounse == 12)
                {
                    money = money + step * 9;
                    Console.WriteLine("Вы умножили свою ставку в 10 раз.");
                }
                Console.WriteLine("\nНа вашем счету {0} очков", money);
                if (money == 0)
                    Console.WriteLine("Вы банкрот. До свидания.");
                else
                {
                    Console.Write("\nПовторить бросок? y/n: ");
                    y = Console.ReadLine();
                }
            } while (y == "y");
        }
    }
}
