using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDay = EnterBirthDay();
            Console.WriteLine("До дня рождения осталось: {0} дней", DaysToBirthDay(birthDay));
            Console.ReadLine();
        }

        static int DaysToBirthDay(DateTime birthDay)
        {
            DateTime now = DateTime.Now;
            DateTime birthDayInCurrentYear = new DateTime(now.Year, birthDay.Month, birthDay.Day);

            if (now > birthDayInCurrentYear)
            {
                DateTime birthDayInNextYear = birthDayInCurrentYear.AddYears(1);
                return (int)(birthDayInNextYear - now).TotalDays;
            }

            return (int)(now - birthDayInCurrentYear).TotalDays;
        }

        private static DateTime EnterBirthDay()
        {
            Console.Write("Введите дату своего рождения: ");
            string time = Console.ReadLine();
            DateTime result;
            if (!DateTime.TryParse(time, out result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректные данные!");
                Console.ResetColor();
                return EnterBirthDay();
            }

            return result;
        }
    }
}
