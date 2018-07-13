using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class BlackAndWhitePrinter : Printer
    {
        private readonly ConsoleColor background = ConsoleColor.White;
        private readonly ConsoleColor foreground = ConsoleColor.Black;

        public override void Print(string value)
        {
            ConsoleColor oldBackground = Console.BackgroundColor;
            ConsoleColor oldForeground = Console.ForegroundColor;

            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            base.Print(value);
            Console.ForegroundColor = oldForeground;
            Console.BackgroundColor = oldBackground;
        }
    }
}
