using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_7_RabbitsVsGooses
{
    class Program
    {
        static void Main(string[] args)
        {
            IlegsCounter counter = new LegsCounter(64);
            counter.GetLegsCount();
            Console.ReadKey();
        }
    }
}
