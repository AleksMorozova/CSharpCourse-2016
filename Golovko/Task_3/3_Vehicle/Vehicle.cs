using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vehicle
{
    abstract class Vehicle
    {
        private Point coordinates;
        private readonly double speed;
        private readonly int year;
        private readonly double price;
        public Point Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }
        public Vehicle(double speed, int year, double price)
        {
            this.speed = speed;
            this.year = year;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("This is {0}", this.GetType().Name);
            Console.WriteLine("Coordinates: ({0}, {1})", coordinates.X, coordinates.Y);
            Console.WriteLine("Speed: {0} km/h", speed);
            Console.WriteLine("Year: {0}", year);
            Console.WriteLine("Price: {0}$", price);
        }
    }
}
