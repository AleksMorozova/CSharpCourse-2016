using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_4_Point
{
    class Point
    {
        private int coordX;
        private int coordY;
        private string stringField;

        public int CoordX { get { return coordX; } }
        public int CoordY { get { return coordY; } }
        public string StringProperty { get { return stringField; } }

        public Point(int coordX, int coordY, string stringField)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.stringField = stringField;
        }
    }
    class Figure
    {
        private string name;
        private Point[] points;

        private double Perimeter { get; set; }
        public string Name { get { return name; } }

        public Figure(Point A, Point B, Point C)
        {
            name = "Triangle";
            points = new Point[]{ A, B, C };
            PerimeterCalculator();
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            name = "Quadrangle";
            points = new Point[] { A, B, C, D};
            PerimeterCalculator();
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            name = "Pentagon";
            points = new Point[] { A, B, C, D, E };
            PerimeterCalculator();
        }
        private double LengthSide(Point A, Point B)
        {
            double x = Math.Pow((A.CoordX - B.CoordX), 2);
            double y = Math.Pow((A.CoordY - B.CoordY), 2);
            return Math.Pow(x + y, 0.5);
        }
        private void PerimeterCalculator()
        {
            for (int i = 0; i < points.Length - 1; i++)
            {
                Perimeter += LengthSide(points[i], points[i + 1]);
            }
            Perimeter += LengthSide(points[0], points[points.Length - 1]);
            
        }
        public void Show()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Perimeter: {0:#.##}", Perimeter);
            Console.WriteLine("");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1, "A");
            Point p2 = new Point(2, 3, "B");
            Point p3 = new Point(3, 4, "C");
            Point p4 = new Point(4, 5, "D");
            Point p5 = new Point(5, 6, "E");

            Figure shape1 = new Figure(p1, p2, p3);
            Figure shape2 = new Figure(p1, p2, p3, p4);
            Figure shape3 = new Figure(p1, p2, p3, p4, p5);

            shape1.Show();
            shape2.Show();
            shape3.Show();

            Console.ReadKey();
        }
    }
}
