using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы посчитать площадь и периметр прямоугольника введите:");
            Console.Write("Длину стороны №1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Длину стороны №2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника: {0}", rect.Area);
            Console.WriteLine("Периметр прямоугольника: {0}", rect.Perimeter);

            Console.ReadLine();
        }
    }
}
