using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4PointAndFigure
{
    class Figure
    {
        List<Point> listOfPoints;
        double perimetr;
        string name;

        public Figure(params Point [] points)
        {
            if (points.Length >= 3 && points.Length <= 5)
            {
                perimetr = 0;
                name = null;
                listOfPoints = new List<Point>();
                foreach (Point p in points)
                {
                    listOfPoints.Add(p);
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Количетсво точек может быть от 3 до 5");              
            }
        }
        

        public void ShowNameAndPerimetr()
        {
            NameCalculator();
            PerimetrCalculator();
            Console.WriteLine("{0} с периметром: {1}", name, perimetr);
        }

        void NameCalculator() 
        {
            switch (listOfPoints.Count)
            {
                case 3:
                    name = "трехугольник";                   
                    break;
                case 4:
                    name = "четырехугольник";
                    break;
                case 5:
                    name = "пятиугольник";
                    break;
            }
            name += " ";
            foreach (Point point in listOfPoints)
            {
                name += point.Name;
            }
        }
        
        void PerimetrCalculator()
        {
            for (int i = 1; i < listOfPoints.Count; i++)
            {
                perimetr += LengthSide(listOfPoints[i-1], listOfPoints[i]);
            }
            perimetr += LengthSide(listOfPoints[0], listOfPoints[listOfPoints.Count-1]);
        }
        
        double LengthSide(Point point1, Point point2)
        {
            double lengthSide = Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + 
                (point2.Y - point1.Y) * (point2.Y - point1.Y));
            return lengthSide;
        } 

       

    }
}
