using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CarCollection
{
    class SportCar : Car
    {
        public string Specification { get; set; }
        public SportCar(string name, double speed, double cost) : base(name, speed, cost)
        {
            this.Specification = "No data";
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Specification: {0}", this.Specification);
        }
    }
}
