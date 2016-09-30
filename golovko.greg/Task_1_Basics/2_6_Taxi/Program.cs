using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarif tarif = new Tarif(5, 20, 3, 1);
            Console.WriteLine("Enter the distance, please:");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the delay, please:");
            double delay = double.Parse(Console.ReadLine());
            ITaxi taxi = new Taxi(distance, delay, (Tarif)tarif);
            Console.WriteLine("Your payment for taxi using is {0} uah", taxi.Payment);
            Console.ReadKey();
        }
    }
}
