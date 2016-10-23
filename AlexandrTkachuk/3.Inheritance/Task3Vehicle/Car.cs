using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Vehicle
{
    class Car: Vehicle
    {
        public Car(Coordinates coordinates, double price, int maxSpeed,int yearOfRelease):
            base(coordinates, price, maxSpeed, yearOfRelease)
        {
           
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Information about Car: ");
            base.ShowInformation();
        }
    }
}
