using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vehicle
{
    class Plane : Vehicle, IPlane, IPassengersCounter
    {
        public double Height { get; set; }
        public int PassengersCount { get; set; }
        public Plane(double speed, int year, double price) : base(speed, year, price) { }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Height is {0} km", Height);
            Console.WriteLine("Passengers count is {0}", PassengersCount);
        }
    }
}
