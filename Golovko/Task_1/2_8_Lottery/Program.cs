using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make your RATE:");
            int rate = int.Parse(Console.ReadLine());
            IGame game = new Game(rate);
            Console.WriteLine(game.Play());
            Console.ReadKey();
        }
    }
}
