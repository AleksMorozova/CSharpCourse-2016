using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Printer_
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer rprint = new RedPrinter();
            Printer gprint = new GreenPrint();

            gprint.Print("Green printer.");
            rprint.Print("\nRed printer.");
            gprint = rprint;
            gprint.Print("\nGreen printer with red printer references.");
            Console.ReadKey();
        }
    }
}
