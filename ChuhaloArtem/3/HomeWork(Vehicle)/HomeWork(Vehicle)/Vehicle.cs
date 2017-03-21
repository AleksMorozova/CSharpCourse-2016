using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Vehicle_
{
    class Vehicle
    {
        private Coordinates coord; 
        private double speed;
        private int year;
        private double price;

        public Vehicle(double speed, int year, double price)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Coordinates Coord
        {
            get { return coord; }
            set { coord = value; }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("\n{0}", this.GetType().Name);
            Console.WriteLine("\nCoordinates: ({0}, {1})", coord.X, coord.Y);
            Console.WriteLine("\nSpeed: {0} km/h", speed);
            Console.WriteLine("\nYear: {0}", year);
            Console.WriteLine("\nPrice: {0} grn\n", price);
        }
    }
}
