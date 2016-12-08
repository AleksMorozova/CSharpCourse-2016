using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Train
{
    struct Train
    {
        string destination;
        int trainNumber;
        TimeSpan timeOfDeparture;

        public Train(string destination, int trainNumber, TimeSpan timeOfDeparture)
        {
            this.destination = destination;
            this.trainNumber = trainNumber;
            this.timeOfDeparture = timeOfDeparture;           
        }

        public void ShowTrainInformation()
        {
            Console.WriteLine("Destination: " + destination);
            Console.WriteLine("Train number: " + trainNumber);
            Console.WriteLine("Time of departure: " + timeOfDeparture);
        }
    }
}
