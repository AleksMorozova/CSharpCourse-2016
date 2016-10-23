using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Coordinates(100,23), 20000, 200, 2010);
            car.ShowInformation();
            Console.WriteLine();

            Plane plane = new Plane(new Coordinates(200, 123), 2000000, 500, 208, 85, 10000);
            plane.ShowInformation();
            Console.WriteLine();

            Ship ship = new Ship(new Coordinates(300, 789), 300000, 120, 2015, 50, "Barcelona");
            ship.ShowInformation();
        }
    }
}
