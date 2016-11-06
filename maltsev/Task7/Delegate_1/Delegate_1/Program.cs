using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, double> mydel1 = delegate (int a, int b, int c)
             {
                 double d = ((double)a + (double)b + (double)c) / 3;
                 return d;
             };

            Console.WriteLine("Delegate| Average of 2,10,55: {0:#.##} ", mydel1(2, 10, 55) );

            Func<int, int, int, double> mydel2 = ( (a, b, c) => ((double)a + (double)b + (double)c) / 3 );
              
            Console.WriteLine("Lambda| Average of 2,10,55: {0:#.##} ", mydel1(2, 10, 55));

            Console.ReadKey();
        }
    }
}
