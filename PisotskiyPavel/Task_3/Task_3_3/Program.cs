using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Vehicle> vehicles = new Vehicle[]
            {
                new Ship(100000, 45.5, 2002, "PORT AUX FRANCAIS") {  PassengersNumber = 10, Coordinates = new GeoCoordinate(89.232258, 121.19878) },
                new Plane(250000, 120, 2005) {PassengersNumber = 2, Height = 3000,Coordinates = new GeoCoordinate(45.251258, 12.159878) },
                new Car(90000, 165, 2001) { Coordinates = new GeoCoordinate(43.23212258, 57.3278)  }
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.PrintInfo();
                Console.WriteLine(new string('-', Console.BufferWidth - 1));
            }

            Console.ReadLine();
        }
    }
}
