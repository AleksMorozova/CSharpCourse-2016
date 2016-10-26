using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class Plane : Vehicle
    {
        public Plane(double price, double speed, int yearOfIssue) 
            : base(price, speed, yearOfIssue)
        {
        }

        public double Height { get; set; }
        public int PassengersNumber { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Высота: {0}", Height);
            Console.WriteLine("Количество пассажиров: {0}", PassengersNumber);
        }

    }
}
