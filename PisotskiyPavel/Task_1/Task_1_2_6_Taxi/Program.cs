using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_6_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите рассояние которое вы проехали(в киллометрах): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество минут простоя: ");
            int waitTime = Convert.ToInt32(Console.ReadLine());

            double fare = Payment(distance, new TimeSpan(0, waitTime, 0));

            Console.WriteLine("Стоимость проезда составляет: {0} грн.", fare);

            Console.ReadLine();
        }

        static double Payment(double distance, TimeSpan waitTime)
        {
            double payment = 20;

            if(distance > 5)
            {
                payment += (distance - 5) * 3;
            }

            payment += waitTime.TotalMinutes;
            
            return payment;
        }
    }
}
