using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Week
    {
        public void Print()
        {
            Console.Write("\nEnter number of day(1-7): ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник!");
                    break;

                case 2:
                    Console.WriteLine("Вторник!");
                    break;

                case 3:
                    Console.WriteLine("Среда!");
                    break;

                case 4:
                    Console.WriteLine("Четверг!");
                    break;

                case 5:
                    Console.WriteLine("Пятница!");
                    break;

                case 6:
                    Console.WriteLine("Суббота!");
                    break;

                case 7:
                    Console.WriteLine("Воскресенье!");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please select proposed item");
                    break;
            }
        }
    }
}
