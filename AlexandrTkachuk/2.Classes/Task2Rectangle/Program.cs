using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если вы вводите дробное число, то в качестве разделителя используйте \',\'");
            Console.Write("Введите длину первой стороны прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второй стороны прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1, side2);
            rectangle.AreaCalculator();
            rectangle.ShowArea();
            rectangle.PerimetrCalculator();
            rectangle.ShowPerimetr();
        }
    }
}
