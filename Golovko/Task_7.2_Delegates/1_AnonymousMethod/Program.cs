using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average arimetic is {0}", AvgCalc.Avg(1, 2, 3));
            Console.WriteLine("Average arimetic is {0}", AvgCalc.Avg(10, 15, 22));
            Console.ReadKey();
        }
    }
}
