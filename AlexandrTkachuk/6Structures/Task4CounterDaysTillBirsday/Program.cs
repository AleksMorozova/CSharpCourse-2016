using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4CounterDaysTillBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday's number of month: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter our birthday's number of the day: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            CounterDaysTillBirthday daysTillBirthday = new CounterDaysTillBirthday(monthNumber, dayNumber);

            Console.Write("Days till birthday: ");
            Console.WriteLine(daysTillBirthday.CalculateQuantityDaysTillBirthday());
        }
    }
}
