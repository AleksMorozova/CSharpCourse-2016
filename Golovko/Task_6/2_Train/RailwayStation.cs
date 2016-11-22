using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Train
{
    class RailwayStation
    {
        private Train[] trains;
        private string Name { get; }
        public RailwayStation(string name)
        {
            this.Name = name;
            trains = new Train[0];
        }
        public void AddTrain(Train train)
        {
            Train[] tmpTrains = new Train[trains.Length + 1];
            Train tmpTrain = train;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].TrainNumber > train.TrainNumber)
                {
                    tmpTrain = trains[i];
                    tmpTrains[i] = train;
                }
                else
                {
                    tmpTrains[i] = trains[i];
                }
            }
            tmpTrains[tmpTrains.Length - 1] = tmpTrain;
            trains = tmpTrains;
        }
        public void PrintInfo(int trainNumber)
        {
            Train train = trains.FirstOrDefault(t => t.TrainNumber == trainNumber);
            if (train.TrainNumber != trainNumber)
            {
                Console.WriteLine("Train with number {0} doesn't exist", trainNumber);
            }
            else
            {
                Console.WriteLine("{0}: Destination -> {1}. Departure Time -> {2}\n", train.TrainNumber, train.Destination, train.DepatureTime);
            }
        }
    }
}
