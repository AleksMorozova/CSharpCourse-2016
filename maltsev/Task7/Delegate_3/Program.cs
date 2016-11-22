using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_3
{
    class Program
    {
        static void Main(string[] args)
        {                       
            Func<int> d1 = Method1;
            Func<int> d2 = Method2;
            Func<int> d3 = Method3;

            Func<int>[] delArr = new Func<int>[] { d1, d2, d3};

            Func< Delegate[], double> AnonMethod = ( delegates =>
            {
                double d = 0;
                foreach (Func<int> item in delegates)
                {
                    d += item();
                }
                return d/3;
            });

            Console.WriteLine( "{0:#.##}", AnonMethod(delArr) ); 
            Console.ReadKey();
        }
        static int Method1()
        {
            DateTime dn = DateTime.Now;
            Random r = new Random(dn.Millisecond);
            return r.Next(100);
        }
        static int Method2()
        {
            DateTime dn = DateTime.Now;
            Random r = new Random(dn.Millisecond);
            return r.Next(100);
        }
        static int Method3()
        {
            DateTime dn = DateTime.Now;
            Random r = new Random(dn.Millisecond);
            return r.Next(100);
        }
    }
}
