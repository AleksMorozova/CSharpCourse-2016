using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Vehicle_
{
    class Plane: Vehicle, IPassagers
    {        
        public Plane(double speed, int year, double price) : base(speed, year, price) { }

        public double Height { get; set; }
        public int Counter { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Height: {0} km", Height);
            Console.WriteLine("Passengers count {0}", Counter);
        }
    }
}
