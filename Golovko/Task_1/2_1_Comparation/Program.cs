using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Comparation
{
    class Program
    {
        static void Main(string[] args)
        {
            IComparer comp = new Comparer(96, 84);
            Console.WriteLine("The max value is {0}", comp.Max);
            Console.ReadKey();
        }
    }
}
