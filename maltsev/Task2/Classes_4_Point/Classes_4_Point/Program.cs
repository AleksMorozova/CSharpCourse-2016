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

        private double Perimeter { get; set; }
        public string Name { get { return name; } }

        public Figure(Point A, Point B, Point C)
        {
            name = "Triangle";
            double[] sides = new double[5];
            sides[0] = LengthSide(A, B);
            sides[1] = LengthSide(B, C);
            sides[2] = LengthSide(C, A);
            for (int i = 0; i < 3; i++)
                Perimeter = Perimeter + sides[i];
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            name = "Quadrangle";
            
            double[] sides = new double[4];
            sides[0] = LengthSide(A, B);
            sides[1] = LengthSide(B, C);
            sides[2] = LengthSide(C, D);
            sides[3] = LengthSide(A, D);
            for (int i = 0; i < 4; i++)
                Perimeter = Perimeter + sides[i];
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            name = "Pentagon";
            double[] sides = new double[5];
            sides[0] = LengthSide(A, B);
            sides[1] = LengthSide(B, C);
            sides[2] = LengthSide(C, D);
            sides[3] = LengthSide(E, D);
            sides[4] = LengthSide(A, E);
            for (int i = 0; i < 5; i++)
                Perimeter = Perimeter + sides[i];
        }
        private double LengthSide(Point A, Point B)
        {
            double x = Math.Pow((A.CoordX - B.CoordX), 2);
            double y = Math.Pow((A.CoordY - B.CoordY), 2);
            return Math.Pow(x + y, 0.5);
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
