using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task2_
{
    struct Train
    {
        private int trainnumber;
        private string findestination;
        private string departureTime;

        public int Number { get { return trainnumber; } }

        public Train(int trainnumber, string findestination, string departureTime)
        {
            this.trainnumber = trainnumber;
            this.findestination = findestination;
            this.departureTime = departureTime;
        }

        public void Show()
        {
            Console.WriteLine("Number:\t\t" + trainnumber);
            Console.WriteLine("Destination:\t" + findestination);
            Console.WriteLine("DepartureTime:\t" + departureTime);
            Console.WriteLine();
        }
    }
}
