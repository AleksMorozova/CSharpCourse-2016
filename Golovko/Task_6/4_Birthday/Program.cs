using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Birth birth = new Birth(new DateTime(1986,11,29));
            Console.WriteLine("Days to your next birthday: {0}", birth.DaysToBirthday);
            Console.ReadKey();
        }
    }
}
