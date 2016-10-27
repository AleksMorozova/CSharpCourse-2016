using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    static class ArrayExtensions
    {
        public static int[] Sort(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if(array[i].CompareTo(array[j]) > 0)
                    {
                        int tempNumber = array[i];
                        array[i] = array[j];
                        array[j] = tempNumber;
                    }
                }
            }

            return array;
        }
    }
}
