using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(2, 2, "A"), new Point(-4, -2, "B"), new Point(4, -2, "C"), new Point(4, 2, "D"));
            Console.WriteLine("Периметр многоугольника {0}: {1}", figure.Name, figure.Perimeter);

            Console.ReadLine();
        }
    }
}
