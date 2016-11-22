using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_4_BDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day:\t");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month:\t");
            int month = Convert.ToInt32(Console.ReadLine());
            DateTime birth = new DateTime(2016, month, day);
            TimeSpan delta = new TimeSpan();

            int compare = DateTime.Compare(birth, DateTime.Today);
            if(compare > 0)
            {
                delta = birth.Subtract(DateTime.Today);
                Console.WriteLine(delta.Days);
            }
            else if (compare < 0)
            {
                delta = DateTime.Today.Subtract(birth);
                Console.WriteLine( delta.Days + 365);
            }
            else Console.WriteLine("Happy B-Day!");

            Console.ReadKey();

        }
    }
}
