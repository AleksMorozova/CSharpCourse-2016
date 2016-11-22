using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CarCollection
{
    class Car
    {
        public string Name { get; protected set; }
        public double Speed { get; protected set; }
        public double Cost { get; protected set; }
        public Car(string name, double speed, double cost)
        {
            this.Name = name;
            this.Speed = speed;
            this.Cost = cost;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("This is {0}", this.GetType().Name);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Cost: {0}", Cost);
        }
    }
}
