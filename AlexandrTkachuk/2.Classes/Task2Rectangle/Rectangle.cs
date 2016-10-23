using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Rectangle
{
    class Rectangle
    {
        double side1;
        double side2;
        double area;
        double perimetr;


        public double Area
        {
            get {return area;}
                
        }
        public double Perimetr
        {
            get {return perimetr;}
        }


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            area = 0;
            perimetr = 0;
        }


        public double AreaCalculator()
        {
            area = side1 * side2;
            return area;
        }

        public double PerimetrCalculator()
        {
            perimetr = 2 * (side1 + side2);          
            return perimetr;
        }

        public void ShowArea()
        {
            Console.WriteLine("Площадь прямоугольника: " + area);
        }

        public void ShowPerimetr()
        {
            Console.WriteLine("Периметр прямоугольника: " + perimetr);
        }
    }
}
