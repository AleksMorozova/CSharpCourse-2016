using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Printer> printers = new Printer[]
            {
                 new ColorPrinter() { Background = ConsoleColor.DarkYellow, Foreground = ConsoleColor.Yellow },
                 new BlackAndWhitePrinter()
            };

            foreach (Printer printer in printers)
            {
                Print(printer, "Hello World!");
            }

            Console.ReadLine();
        }

        static void Print(Printer printer, string value)
        {
            printer.Print(value);
        }
    }
}
