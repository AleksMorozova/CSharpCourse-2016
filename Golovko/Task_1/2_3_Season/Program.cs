using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_Season
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeason season = new Season();
            Console.WriteLine("Enter the month number, please:");
            Console.WriteLine(season.GetSeason((Month)Convert.ToByte(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
