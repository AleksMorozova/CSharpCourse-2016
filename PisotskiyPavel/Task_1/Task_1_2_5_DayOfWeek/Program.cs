using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_5_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDayOfWeekByNumber(number));
            Console.ReadLine();
        }

        static string GetDayOfWeekByNumber(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 1: result = "Понедельник";break;
                case 2: result = "Вторник"; break;
                case 3: result = "Среда"; break;
                case 4: result = "Четверг"; break;
                case 5: result = "Пятница"; break;
                case 6: result = "Суббота"; break;
                case 7: result = "Воскресенье"; break;
                default: result = "Такого дня недели на этой планете нет.";
                    break;
            }

            return result;
        }
    }
}
