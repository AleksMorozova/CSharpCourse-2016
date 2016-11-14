using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 2, 16, 8 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            array.GetSorted(SortType.FromBiger);
            array.GetSorted(SortType.FromSmaller);
            Console.ReadKey();
        }
    }
}
