using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Task3_
{
    delegate int RndDelegate();
    delegate double AvgDelegate(RndDelegate[] rndDelegatesArray);

    class Program
    {
        static void Main(string[] args)
        {
            double avg = Average.Avg(new RndDelegate[]
            {
                new RndDelegate(Average.GetRnd),
                new RndDelegate(Average.GetRnd),
                new RndDelegate(Average.GetRnd),
                new RndDelegate(Average.GetRnd),
                new RndDelegate(Average.GetRnd),
                new RndDelegate(Average.GetRnd)
            });
            Console.WriteLine("Average arifmetic is {0}", avg);
            Console.ReadKey();
        }
    }
}
