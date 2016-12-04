using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_1
{
    class Program
    {
        static Func<int, int, int, double> average = delegate (int a, int b, int c) { return (a + b + c) / 3.0; };

        static void Main(string[] args)
        {
            int x = 76, y = 23, z = 43;
            
            Console.WriteLine("Среднее арифметическое чисел {0}, {1}, {2} : {3}", x, y, z, average(x, y, z));

            Console.ReadLine();
        }
    }
}
