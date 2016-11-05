using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            RailwayStation railwayStation = new RailwayStation("Dnepr");
            int trainNumber;
            string destination;
            DateTime depatureTime;
            int counter = 0;
            string toAdd;
            while (true)
            {
                Console.WriteLine("Do you want add new Train? (y - yes, n - no):");
                toAdd = Console.ReadLine();
                if (toAdd == "y")
                {
                    Console.WriteLine("Train[{0}]:", counter++);
                    Console.Write("Enter train number: ");
                    int.TryParse(Console.ReadLine(), out trainNumber);
                    Console.Write("Enter destination: ");
                    destination = Console.ReadLine();
                    Console.Write("Enter depature time: ");
                    DateTime.TryParse(Console.ReadLine(), out depatureTime);
                    railwayStation.AddTrain(new Train(trainNumber, destination, depatureTime));
                }
                else if (toAdd == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown answer");
                }
                
            }
            Console.Write("Enter the train number for getting arrival info: ");
            int.TryParse(Console.ReadLine(), out trainNumber);
            railwayStation.PrintInfo(trainNumber);
            Console.ReadKey();
        }
    }
}
