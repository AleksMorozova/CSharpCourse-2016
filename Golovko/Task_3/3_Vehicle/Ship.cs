using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Vehicle
{
    class Ship : Vehicle, IShip, IPassengersCounter
    {
        public string PortName { get; set; }
        public int PassengersCount { get; set; }
        public Ship(double speed, int year, double price) : base(speed, year, price) { }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Port name: {0}", PortName);
            Console.WriteLine("Passengers count is {0}", PassengersCount);
        }
    }
}
