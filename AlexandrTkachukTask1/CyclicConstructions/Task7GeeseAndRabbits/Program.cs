using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7GeeseAndRabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У гусей и кроликов вместе 64 лапы. Все возможные сочетания : ");
            for (int i = 0; i <= 64; i += 2)
            {
                for (int j = 0; j <= 64; j += 4)
                {
                    if (i + j == 64)
                    {
                        Console.WriteLine(i / 2 + " гусей и " + j / 4 + " кроликов");
                    }
                }
            }
        }
    }
}
