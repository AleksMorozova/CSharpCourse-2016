using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Printers
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class PrinterBlue : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }
    }
    class PrinterGreen : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] pr = new Printer [3] { new Printer(), new PrinterBlue(), new PrinterGreen()};
            foreach (var item in pr)
                item.Print("Print me!");
            Console.ReadKey();
        }
    }
}
