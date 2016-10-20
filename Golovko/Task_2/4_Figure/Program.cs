using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(
                new Point(3, 5, "A"), 
                new Point(7, -2, "B"), 
                new Point(1, 5, "C"), 
                new Point(14, 3, "D"));

            Console.WriteLine("P({0}) = {1:f4}", figure.Name, figure.Perimeter);
            Console.ReadKey();
        }
    }
}
