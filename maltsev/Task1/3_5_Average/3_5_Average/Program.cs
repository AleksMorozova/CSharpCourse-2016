using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_5_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}-е число: ", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + a[i];
            }
            Console.WriteLine("Среднее арифм. = {0}", sum/5);
            Console.ReadKey();
        }
    }
}
