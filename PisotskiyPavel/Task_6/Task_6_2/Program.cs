using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Train> trains = new List<Train>();
            int trainsNumber = 2;


            while (trains.Count < trainsNumber )
            {
                Console.WriteLine("Поезд №{0}:", trains.Count + 1);
                AddTrain(trains);
                Console.WriteLine(new string('-', Console.BufferWidth - 1));
            }

            Console.Clear();

            trains.Sort();

            while (true)
            {
                int trainNumber = GetInteger("Для вывода информации о поезде, введите его номер: ");
                int index = trains.FindIndex(t => t.TrainNumber == trainNumber);

                if(index == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Информация о данном поезде не найденна:");
                    Console.ResetColor();
                }
                else
                {
                    trains[index].PrintInfo();
                }
                Console.WriteLine(new string('-', Console.BufferWidth - 1));
            }

        }

        static void AddTrain(ICollection<Train> trains)
        {
            int trainNumber = EnterTrainNumber();
            string destination = EnterDestination();
            DateTime departureTime = EnterDepartureTime();

            trains.Add(new Train()
            {
                TrainNumber = trainNumber,
                Destination = destination,
                DepartureTime = departureTime
            });
        }



        private static int EnterTrainNumber()
        {
            return GetInteger("Введите номер поезда: ");
        }

        private static int GetInteger(string message)
        {
            Console.Write(message);
            string num = Console.ReadLine();

            int result;
            if (!int.TryParse(num, out result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректные данные!");
                Console.ResetColor();
                return EnterTrainNumber();
            }
            return result;
        }

        private static string EnterDestination()
        {
            Console.Write("Введите название пункта назначения: ");
            string destination = Console.ReadLine();
            if (destination.Equals(string.Empty))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректные данные!");
                Console.ResetColor();
                return EnterDestination();
            }

            return destination;
        }

        private static DateTime EnterDepartureTime()
        {
            Console.Write("Введите время отправления: ");
            string time = Console.ReadLine();
            DateTime result;
            if (!DateTime.TryParse(time, out result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректные данные!");
                Console.ResetColor();
                return EnterDepartureTime();
            }

            return result;
        }
    }
}
