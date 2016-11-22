using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200, 2016, 50000);
            car.Coordinates = new Point(12, 87);
            car.PrintInfo();
            Plane plane = new Plane(800, 2013, 600000);
            plane.Coordinates = new Point(102, 316);
            plane.Height = 2000;
            plane.PassengersCount = 120;
            plane.PrintInfo();
            Ship ship = new Ship(220, 2010, 300000);
            ship.Coordinates = new Point(44, 62);
            ship.PortName = "Glasgow";
            ship.PassengersCount = 800;
            ship.PrintInfo();
            Console.ReadKey();
        }
    }
}
