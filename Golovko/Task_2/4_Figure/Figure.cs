using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Figure
{
    class Figure
    {
        private Point[] points;
        public string Name
        {
            get
            {
                string name = string.Empty;
                foreach (Point point in points)
                {
                    if (point == null) break;
                    name += point.Name;
                }
                return name;
            }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
        public Figure(Point pointA, Point pointB, Point pointC)
        {
            points = new Point[5];
            points[0] = pointA;
            points[1] = pointB;
            points[2] = pointC;
        }
        public Figure(Point pointA, Point pointB, Point pointC, Point pointD) : 
            this(pointA, pointB, pointC)
        {
            points[3] = pointD;
        }
        public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE) :
            this(pointA, pointB, pointC, pointD)
        {
            points[4] = pointE;
        }
        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        private double PerimeterCalculator()
        {
            int k = 0;
            double perimeter = 0;
            while (points[++k] != null)
            {
                perimeter += LengthSide(points[k-1], points[k]);
            }            
            perimeter += LengthSide(points[0], points[--k]);
            return perimeter;
        }
    }
}
