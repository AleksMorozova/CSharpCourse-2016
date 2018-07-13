using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_5
{
    static class Printer
    {
        public static void Print(string text, int color)
        {
            Console.ForegroundColor = GetConsoleColor((Colors)color);
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private static ConsoleColor GetConsoleColor(Colors colors)
        {
            switch (colors)
            {
                case Colors.Red:
                    return ConsoleColor.Red;
                case Colors.Yellow:
                    return ConsoleColor.Yellow;
                case Colors.Green:
                    return ConsoleColor.Green;
                case Colors.Blue:
                    return ConsoleColor.Blue;
                default:
                    return ConsoleColor.Gray;
            }
        }
    }
}
