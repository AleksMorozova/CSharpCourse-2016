using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task3_
{
    static class Sort
    {
        public static void GetSorted(this int[] array, SortType type)
        {

            int x;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j] * (type == SortType.FromBiger ? 1 : -1))
                    {
                        x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }

            Console.Write("\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
