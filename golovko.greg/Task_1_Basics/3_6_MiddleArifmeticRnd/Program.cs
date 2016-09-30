using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_MiddleArifmeticRnd
{
    class Program
    {
        static void Main(string[] args)
        {
            INumber numbers = new Number(1, 100, 5);
            Console.WriteLine("Middle arifmetic is {0}", numbers.GetMiddleArifmetic());
            Console.ReadKey();
        }
    }
}
