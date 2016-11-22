using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Train
{
    struct Train
    {
        private readonly string destiantion;
        private readonly int trainNumber;
        private readonly DateTime depatureTime;
        public string Destination { get { return destiantion; } }
        public int TrainNumber { get { return trainNumber; } }
        public DateTime DepatureTime { get { return depatureTime; } }
        public Train(int trainNumber, string destiantion, DateTime depatureTime)
        {
            this.destiantion = destiantion;
            this.trainNumber = trainNumber;
            this.depatureTime = depatureTime;
        }
    }
}
