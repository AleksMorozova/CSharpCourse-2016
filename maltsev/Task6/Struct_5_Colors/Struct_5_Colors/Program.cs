using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_5_Colors
{
    static class Printer
    {
        static public void Print(string str, int color)
        {
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string:");
            string str = Console.ReadLine();
            Console.WriteLine("Choose your color (1:15): ");
            foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.WriteLine((int)item + ": " + item);
            }

            int choice = Convert.ToInt32(Console.ReadLine());
            Printer.Print(str, choice);

            Console.ReadKey();

        }
    }
}
