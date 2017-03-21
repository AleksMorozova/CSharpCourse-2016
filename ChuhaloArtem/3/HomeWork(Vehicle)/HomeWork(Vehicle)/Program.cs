using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Vehicle_
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200, 2016, 100);
            car.Coord = new Coordinates(10, 100);
            car.PrintInfo();

            Plane plane = new Plane(800, 2015, 100000);
            plane.Coord = new Coordinates(20, 200);
            plane.Height = 5000;
            plane.Counter = 500;
            plane.PrintInfo();

            Ship ship = new Ship(300, 2014, 10000);
            ship.Coord = new Coordinates(30, 300);
            ship.PortName = "OdessaPort";
            ship.Counter = 2000;
            ship.PrintInfo();

            Console.ReadKey();
        }
    }
}
