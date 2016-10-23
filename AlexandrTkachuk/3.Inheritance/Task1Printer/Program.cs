using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Printer bluePrinter = new BluePrinter();
            Printer redPrinter = new RedPrinter();
            printer.Print("Printer");
            bluePrinter.Print("BluePrinter");                       
            redPrinter.Print("RedPrinter");

        }
    }
}
