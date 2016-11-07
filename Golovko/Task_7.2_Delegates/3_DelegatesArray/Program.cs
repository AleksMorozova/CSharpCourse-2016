using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DelegatesArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgArifmetic = AvgCalculator.Avg(new RndDelegate[]
            {
                new RndDelegate(Generator.GetRand),
                new RndDelegate(Generator.GetRand),
                new RndDelegate(Generator.GetRand),
                new RndDelegate(Generator.GetRand),
                new RndDelegate(Generator.GetRand)
            });
            Console.WriteLine("Average arifmetic is {0}", avgArifmetic);
            Console.ReadKey();
        }
    }
}
