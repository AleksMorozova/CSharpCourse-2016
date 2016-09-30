using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            IMultiplyTable table = new MultiplyTable(20);
            Console.WriteLine("Enter the number for multiplying:");
            int multilier = int.Parse(Console.ReadLine());
            table.ToBuild(multilier);
            Console.ReadKey();
        }
    }
}
