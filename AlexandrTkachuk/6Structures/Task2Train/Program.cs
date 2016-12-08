using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[3];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Enter information about {0} train:", i+1);
                trains[i] = CreateTrain();
                Console.Clear();  
            }
            ShowInformationAboutTrain(trains);
            
        }

        private static void ShowInformationAboutTrain(Train[] trains)
        {
            Console.Write("To get information about train enter the number of train: ");
            int trainNumber = Convert.ToInt32(Console.ReadLine());
            trains[trainNumber - 1].ShowTrainInformation();
        }

        static Train CreateTrain()
        {                
                Console.Write("Destination: ");
                string destination = Console.ReadLine();
                Console.Write("Train number: ");
                int trainNumber = Convert.ToInt32(Console.ReadLine());
                TimeSpan timeOfDeparture = DetermineTime();                                       
                return new Train(destination, trainNumber, timeOfDeparture);
        }

        static TimeSpan DetermineTime()
        {
            Console.Write("Enter time of departure in format h:m:s (examle 12:45:00): ");
            string timeOfDeparture = Console.ReadLine();
            string[] hoursMinutesSeconds = timeOfDeparture.Split(':');
            int hours = Convert.ToInt32(hoursMinutesSeconds[0]);
            int minutes = Convert.ToInt32(hoursMinutesSeconds[1]);
            int seconds = Convert.ToInt32(hoursMinutesSeconds[2]);
            return new TimeSpan(hours, minutes,seconds);
        }


    }
}
