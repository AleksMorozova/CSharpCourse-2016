using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5ColorPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a line: ");
            string enteredLine = Console.ReadLine();
            Console.Write("Choose the line's color (green - 1, red - 2, blue - 3, yellow - 4): ");
            int color = Convert.ToInt32(Console.ReadLine());
            ColorPrinter.Print(enteredLine, color);
        }
    }
}
