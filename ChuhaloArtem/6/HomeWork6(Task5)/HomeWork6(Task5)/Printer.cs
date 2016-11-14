using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task5_
{
    class Printer
    {
        public static void Print(string line, int color)
        {
            ChooseColor(color-=1);
            Console.WriteLine(line);
        }

        static void ChooseColor(int color)
        {
            ColorsLib linecolor = (ColorsLib)color;
            switch (linecolor)
            {
                case ColorsLib.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ColorsLib.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case ColorsLib.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case ColorsLib.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Invalid color.");
                    break;
            }
        }
    }
}
