using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Printer_
{
    class RedPrinter: Printer
    {
        public override void Print(string value)
        {           
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
        }
    }
}
