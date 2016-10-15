using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_3_7_GeeseAndRabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            int legs = 64;
            for (int i = 0; i <= legs; i += 2)
            {
                if((legs - i) % 4 == 0)
                {
                    int geese = i / 2;
                    int rabbits = (legs - i) / 4;
                    Console.WriteLine("Гусей: {0},а кроликов: {1}", geese, rabbits);
                }
            }

            Console.ReadLine();
        }
    }
}
