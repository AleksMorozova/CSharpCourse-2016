using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_2
{
    struct Train : IComparable<Train> 
    {
        public string Destination { get; set; }
        public int TrainNumber { get; set; }
        public DateTime DepartureTime { get; set; }

        public Train(int trainNumber, string destination, DateTime departureTime)
        {
            Destination = destination;
            TrainNumber = trainNumber;
            DepartureTime = departureTime;
        }

        public int CompareTo(Train other)
        {
            return this.TrainNumber.CompareTo(other.TrainNumber);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Номер поезда: {0}", TrainNumber);
            Console.WriteLine("Название пункта назначения: {0}", Destination);
            Console.WriteLine("Время отправления: {0}", DepartureTime);
        }
    }
}
