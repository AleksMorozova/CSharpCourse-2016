using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    abstract class Vehicle
    {
        public GeoCoordinate Coordinates { get; set; }

        public double Price { get; set; }

        public double Speed { get; protected set; }

        public int YearOfIssue { get; protected set; }

        public Vehicle(double price, double speed, int yearOfIssue)
        {
            Price = price;
            Speed = speed;
            YearOfIssue = yearOfIssue;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine("Координаты: {0}", Coordinates.ToString());
            Console.WriteLine("Цена: {0}", Price);
            Console.WriteLine("Скорость: {0}", Speed);
            Console.WriteLine("Год выпуска: {0}", YearOfIssue);
        }
    }
}
