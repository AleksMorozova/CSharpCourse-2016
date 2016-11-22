﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Rectangle
{
    class Rectangle
    {
        private double side1;
        private double side2;
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
}
