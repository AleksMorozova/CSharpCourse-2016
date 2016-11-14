using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 4, -1, 2, 16, 8 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            array.GetSorted();
            Console.ReadKey();
        }
    }
}
