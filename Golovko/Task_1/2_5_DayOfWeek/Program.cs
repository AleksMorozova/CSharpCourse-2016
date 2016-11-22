using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            IDay day = new Day();
            Console.WriteLine("Enter the week's day number:");
            Console.WriteLine("This is {0}", day.GetName((DayName)Convert.ToByte(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
