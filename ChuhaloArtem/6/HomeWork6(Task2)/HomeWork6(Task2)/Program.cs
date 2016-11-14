using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[2];

            AddTrain(trains);
            SortTrain(trains);
            ShowTrain(trains);
            ShowByNumber(trains);

            Console.ReadKey();
        }

        static public void AddTrain(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("{0} train", i + 1);
                Console.Write("Number:\t\t");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Destination:\t");
                string dest = Console.ReadLine();
                Console.Write("DepartureTime:\t");
                string dep = Console.ReadLine();
                Console.WriteLine();
                trains[i] = new Train(number, dest, dep);
            }
        }

        static public void SortTrain(Train[] trains)
        {
            for (int i = 0; i < trains.Length - 1; i++)
                for (int j = i + 1; j < trains.Length; j++)
                {
                    if (trains[i].Number > trains[j].Number)
                    {
                        Train temp = new Train();
                        temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
        }

        static public void ShowTrain(Train[] trains)
        {
            Console.WriteLine("All trains: ");
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i].Show();
            }
        }

        static public void ShowByNumber(Train[] trains)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Number == num)
                {
                    trains[i].Show();
                    return;
                }
            }
            Console.WriteLine("Number is not found");
        }
    }
}
