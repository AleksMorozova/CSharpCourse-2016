using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Rectangle's sides lenght, pleas:");
            Console.Write("A = ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Area = {0}\nPerimeter = {1}", rectangle.Area, rectangle.Perimeter);
            Console.ReadKey();
        }
    }
}
