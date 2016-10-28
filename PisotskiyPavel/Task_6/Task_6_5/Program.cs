using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите цвет: ");
            foreach (var value in Enum.GetValues(typeof(Colors)))
            {
                Console.ForegroundColor = GetConsoleColor((Colors)value);
                Console.Write("{0} ", (int)value);
                Console.ResetColor();
            }

            Console.Write("{0}Введите номер цвета: ", Environment.NewLine);

            int color = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.Write("Результат: ");
            Printer.Print(text, color);

            Console.ReadLine();
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
