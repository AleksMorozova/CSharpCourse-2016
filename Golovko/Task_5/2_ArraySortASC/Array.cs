using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ArraySortASC
{
    static class Array
    {
        public static int[] SortAsc(this int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }
        public static void Print(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
        }
    }
}
