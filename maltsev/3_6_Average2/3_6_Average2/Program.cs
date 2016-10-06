using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_6_Average2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rand_val;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                rand_val = rand.Next(1, 101);
                Console.WriteLine("{0}-е число: {1} ", i + 1, rand_val);
                sum += rand_val;
            }
            Console.WriteLine("Среднее арифм. = {0}", sum / 5);
            Console.ReadKey();
        }
    }
}
