using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ArraySortAscDesc
{
    static class Array
    {
        public static int[] Sort(this int[] array, SortType type)
        {
            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (type == SortType.ASC)
                    {
                        if (array[i] > array[j])
                        {
                            tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                    else
                    {
                        if (array[i] < array[j])
                        {
                            tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
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
