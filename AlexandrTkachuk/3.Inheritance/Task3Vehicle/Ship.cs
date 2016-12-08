using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vehicle
{
    class Ship: Vehicle
    {
        int passengerQuantity;
        string portName;

        public Ship(Coordinates coordinates, double price, int maxSpeed,
            int yearOfRelease, int passengerQuantiy, string portName):
            base(coordinates, price, maxSpeed, yearOfRelease)
        {
            this.passengerQuantity = passengerQuantiy;
            this.portName = portName;
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Information about Ship:");
            base.ShowInformation();
            Console.WriteLine("Quantiy of passengers: " + passengerQuantity);
            Console.WriteLine("Name of port: " + portName);
        }

    }
}
