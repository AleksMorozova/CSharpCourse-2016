using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Figure
    {
        public Point a;
        int angels;
        int length;
        string name;
     
        public Figure(Point a)
        {
            this.angels = a.GetA;
            this.length = a.GetB;
            this.name = a.GetName;
        }
        
        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Perimetr
        {
            get { return PerimeterCalculator(); }
        }
        public int PerimeterCalculator()
        {
            int p;
            p = angels * length;
            return p;
        }
    }
}
