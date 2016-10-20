using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Printer();
            printer.Print("Default print");            
            IPrinter colourPrinter = new ColourPrinter();
            colourPrinter.Print("Colour print");
            printer = colourPrinter;
            printer.Print("Transfer the ref to Colour printer");
            IPrinter bwPrinter = new BlackWhitePrinter();
            bwPrinter.Print("Black and White print");
            printer = bwPrinter;
            printer.Print("Transfer the ref to Black and White printer");
            Console.ReadKey();
        }
    }
}
