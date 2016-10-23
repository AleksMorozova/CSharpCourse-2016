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
            for (int goose = 0; goose <= 64; goose += 2)
            {
                for (int rabbit = 0; rabbit <= 64; rabbit += 4)
                {
                    if (goose + rabbit == 64)
                    {
                        Console.WriteLine(goose / 2 + " гусей и " + rabbit / 4 + " кроликов");
                    }
                }
            }
        }
    }
}
