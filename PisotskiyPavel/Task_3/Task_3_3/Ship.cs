using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class Ship : Vehicle
    {
        public Ship(double price, double speed, int yearOfIssue, string registryPort) 
            : base(price, speed, yearOfIssue)
        {
            RegistryPort = registryPort;
        }

        public int PassengersNumber { get; set; }
        public string RegistryPort { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Порт приписки: {0}", RegistryPort);
            Console.WriteLine("Количество пассажиров: {0}", PassengersNumber);
        }
    }
}
