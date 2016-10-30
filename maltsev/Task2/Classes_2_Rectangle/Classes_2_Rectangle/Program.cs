using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1_Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area
        {
            get { return this.AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return this.PerimeterCalculator(); }
        }

        public Rectangle()
        {
            this.side1 = 0;
            this.side2 = 0;
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double AreaCalculator()
        {
            return side2 * side1;
        }
        private double PerimeterCalculator()
        {
            return 2*(side1+side2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle exz = new Rectangle(side1, side2);

            Console.WriteLine("Perimeter: {0}", exz.Perimeter);
            Console.WriteLine("Area: {0}", exz.Area);
       
            Console.ReadKey();

        }
    }
}
