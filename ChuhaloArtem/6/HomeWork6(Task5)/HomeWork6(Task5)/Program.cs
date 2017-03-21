using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourline;
            int color;

            Console.Write("Your line: ");
            yourline = Console.ReadLine();
            Console.Write("\nChoose the color (): ");
            color = Convert.ToInt32(Console.ReadLine());

            Printer.Print(yourline, color);
            Console.ReadKey();
        }
    }
}
