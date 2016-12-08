using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vehicle
{
    class Vehicle
    {
        protected Coordinates coordinates;
        protected double price;
        protected int maxSpeed;
        protected int yearOfRelease;

        public Vehicle(Coordinates coordinates, double price, int maxSpeed, int yearOfRelease)
        { 
            this.coordinates = coordinates;
            this.price = price;
            this.maxSpeed = maxSpeed;
            this.yearOfRelease = yearOfRelease;
        }

        public virtual void ShowInformation()
        {
            Console.WriteLine("Coordinates: x = {0}, y = {1}", coordinates.X, coordinates.Y);
            Console.WriteLine("Price: {0}$\nMax speed: {1} km/h", price, maxSpeed);
            Console.WriteLine("Year of release: " + yearOfRelease);
        }
    }
}
