using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vehicle
{
    class Plane: Vehicle
    {
        int passengerQuantity;
        int maxHeigh;      

        public Plane(Coordinates coordinates, double price, int maxSpeed,
            int yearOfRelease, int passengerQuantiy, int maxHeigh ):
            base(coordinates, price, maxSpeed, yearOfRelease)
        {
            this.passengerQuantity = passengerQuantiy;
            this.maxHeigh = maxHeigh;         
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Information about Plane:");
            base.ShowInformation();
            Console.WriteLine("Quantiy of passengers: " + passengerQuantity);
            Console.WriteLine("Max height: {0} meters", maxHeigh);
        }
    }
}
