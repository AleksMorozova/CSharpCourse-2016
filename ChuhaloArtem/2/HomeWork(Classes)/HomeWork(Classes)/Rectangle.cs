using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle()
        {

        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = 0;
            this.side2 = 0;           
        }

        public double Set_Side1
        {
            set { side1 = value; }
        }

        public double Set_Side2
        {
            set { side2 = value; }
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimetr
        {
            get { return PerimetrCalculator(); }
        }

        private double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        private double PerimetrCalculator()
        {
            double per = (side1 + side2) * 2;
            return per;
        }
    }
}
