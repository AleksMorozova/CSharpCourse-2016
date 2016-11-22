using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_2_Train
{
    struct Train
    {
        private int number;
        private string destination;
        private string departureTime;

        public int Number { get { return number; } }
        
        public Train(int number, string dest, string dep)
        {
            this.number = number;
            this.destination = dest;
            this.departureTime = dep;
        }

        public void Show()
        {
            Console.WriteLine("Number:\t\t" + number);
            Console.WriteLine("Destination:\t" + destination);
            Console.WriteLine("DepartureTime:\t" + departureTime);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[3];//8

            Input(trains);
            Sort(trains);
            Show(trains);
            OutputByNumber(trains);
                
            Console.ReadKey();
             
        }
        
        static public void Input(Train[] _trains)
        {
            for (int i = 0; i < _trains.Length; i++)
            {
                Console.WriteLine("{0} train" , i+1);
                Console.Write("Number:\t\t");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Destination:\t");
                string dest = Console.ReadLine();
                Console.Write("DepartureTime:\t");
                string dep = Console.ReadLine();
                Console.WriteLine();
                _trains[i] = new Train(number, dest, dep);
            }
        }
        static public void Sort(Train[] _trains)
        {
            for(int i = 0; i < _trains.Length - 1; i++)
                for (int j = i+1; j < _trains.Length; j++)
                {
                    if(_trains[i].Number > _trains[j].Number)
                    {
                        Train temp = new Train();
                        temp = _trains[i];
                        _trains[i] = _trains[j];
                        _trains[j] = temp;
                    }
                }
        }
        static public void Show(Train[] _trains)
        {
            Console.WriteLine( "All trains: ");
            for (int i = 0; i < _trains.Length; i++)
            {
                _trains[i].Show();
            }
        }
        static public void OutputByNumber(Train[] _trains)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _trains.Length; i++)
            {
                if (_trains[i].Number == num)
                { 
                    _trains[i].Show();
                    return;
                }
            }
            Console.WriteLine("Number is not found");
        }
    }
}
