using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Printer
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = GetColor(color);
            Console.WriteLine(stroka);
            Console.ResetColor();
        }

        private static ConsoleColor GetColor(int color)
        {
            ConsoleColor resultColor;
            Color paintColor = (Color)color;
            switch (paintColor)
            {
                case Color.Blue:
                    resultColor = ConsoleColor.Blue;
                    break;
                case Color.Gray:
                    resultColor = ConsoleColor.Gray;
                    break;
                case Color.Green:
                    resultColor = ConsoleColor.Green;
                    break;
                case Color.Red:
                    resultColor = ConsoleColor.Red;
                    break;
                case Color.White:
                    resultColor = ConsoleColor.White;
                    break;
                case Color.Yellow:
                    resultColor = ConsoleColor.Yellow;
                    break;
                default:
                    resultColor = ConsoleColor.Gray;
                    Console.WriteLine("Unknown color. Setup the deffault color 'Gray'");
                    break;
            }
            return resultColor;
        }

        public static void ShowColorList()
        {
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine("{0} -> {1}", (int)color, Enum.GetName(typeof(Color), color));
            }
        }
    }
}
