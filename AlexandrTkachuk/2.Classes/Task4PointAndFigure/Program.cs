using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4PointAndFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point("A", 2, 2);
            Point point2 = new Point("B", 2, -2);
            Point point3 = new Point("C", -2, -2);
            Figure f1 = new Figure(point1, point2, point3);
            f1.ShowNameAndPerimetr();
        }
    }
}
