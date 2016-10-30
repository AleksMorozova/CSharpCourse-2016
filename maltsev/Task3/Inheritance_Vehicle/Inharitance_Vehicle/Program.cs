using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Vehicle
{
    class Vehicle
    {
        private double coordX;
        private double coordY;
        private double price;
        private double speed;
        private int yearMade;
        public Vehicle(double coordX, double coordY, double price, double speed, int yearMade)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.price = price;
            this.speed = speed;
            this.yearMade = yearMade;
        }
        public virtual void Info()
        {
            Console.WriteLine("coordX \t\t" + coordX);
            Console.WriteLine("coordY \t\t" + coordY);
            Console.WriteLine("price \t\t" + price);
            Console.WriteLine("speed \t\t" + speed);
            Console.WriteLine("yearMade \t" + yearMade);
        }
    }
    class Plane: Vehicle
    {
        private int personsOnBoard;
        private double height;
        public Plane(double coordX, double coordY, double price, double speed, int yearMade, 
            int personsOnBoard, double height) : base(coordX,  coordY, price, speed, yearMade)
        {
            this.personsOnBoard = personsOnBoard;
            this.height = height;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("personsOnBoard \t" + personsOnBoard);
            Console.WriteLine("height \t\t" + height);
        }
    }
    class Car: Vehicle
    {
        public Car(double coordX, double coordY, double price, double speed,
            int yearMade) : base(coordX,  coordY, price, speed, yearMade){ }
    }
    class Ship: Vehicle
    {
        private int personsOnBoard;
        private string destinationPort;
        public Ship(double coordX, double coordY, double price, double speed, int yearMade,
            int personsOnBoard, string destinationPort) : base(coordX,  coordY, price, speed, yearMade)
        {
            this.personsOnBoard = personsOnBoard;
            this.destinationPort = destinationPort;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("personsOnBoard \t" + personsOnBoard);
            Console.WriteLine("destPort \t" + destinationPort);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] veh = new Vehicle[3];
            veh[0] = new Plane(2324.1, 341.2, 34200.0, 300.0, 1985, 80, 3000.0);
            veh[1] = new Car(223.1, 1134.2, 8000.0, 120.0, 1995);
            veh[2] = new Ship(1234.1, 454463.2, 5500.0, 200.0, 1979, 400, "Carribean");

            foreach (var item in veh)
            {
                item.Info();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
