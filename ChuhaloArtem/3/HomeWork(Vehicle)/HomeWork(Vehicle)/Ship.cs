using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Vehicle_
{
    class Ship: Vehicle, IPassagers
    {
       
        public Ship(double speed, int year, double price) : base(speed, year, price) { }

        public string PortName { get; set; }
        public int Counter { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Port: {0}", PortName);
            Console.WriteLine("Passengers count {0}", Counter);
        }
    }
}
