using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class ColorPrinter : Printer
    {
        public ConsoleColor Background { get; set; }
        public ConsoleColor Foreground { get; set; }

        public ColorPrinter()
        {
            Background = ConsoleColor.White;
            Foreground = ConsoleColor.Black;
        }

        public override void Print(string value)
        {
            ConsoleColor oldBackground = Console.BackgroundColor;
            ConsoleColor oldForeground = Console.ForegroundColor;

            Console.ForegroundColor = Foreground;
            Console.BackgroundColor = Background;
            base.Print(value);
            Console.ForegroundColor = oldForeground;
            Console.BackgroundColor = oldBackground;
        }
    }
}
