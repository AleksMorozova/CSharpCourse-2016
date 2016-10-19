using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_4
{
    class Figure
    {
        private readonly Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[3] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[4] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[5] { p1, p2, p3, p4, p5 };
        }

        public double LenghtSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public double Perimeter { get { return PerimeterCalculator(); } }

        public string Name
        {
            get
            {
                string name = string.Empty;

                foreach (Point point in points)
                {
                    name += point.Name;
                }

                return name;
            }
        }

        private double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LenghtSide(points[i], points[i + 1]);
            }

            perimeter += LenghtSide(points[points.Length - 1], points[0]);

            return perimeter;
        }
    }
}
