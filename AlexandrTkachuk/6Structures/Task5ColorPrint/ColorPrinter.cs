using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5ColorPrint
{
    static class ColorPrinter
    {
        public static void Print(string line, int color)
        {
            ChooseLineColor(color);
            Console.WriteLine(line);

            Console.ResetColor();
        }

        static void ChooseLineColor(int color)
        {
            Color colorOfLine = (Color)color;
            switch (colorOfLine)
            { 
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wrong color!!!");
                    break;
            }
        }
    }
}
