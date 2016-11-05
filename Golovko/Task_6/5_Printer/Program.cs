using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            int color;
            Console.Write("Enter text for printing, please:");
            text = Console.ReadLine();
            Console.WriteLine("Select color index, please:");
            Printer.ShowColorList();
            if (int.TryParse(Console.ReadLine(), out color))
            {
                Printer.Print(text, color);
            }
            else
            {
                Console.WriteLine("Uncorrect color index format");
            }
            Console.ReadKey();
        }
    }
}
