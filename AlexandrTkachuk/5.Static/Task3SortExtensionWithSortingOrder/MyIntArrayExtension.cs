using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3SortExtensionWithSortingOrder
{
    public static class MyIntArrayExtension
    {
        public static void SortArray(this int[] array, bool SortingOrder)
        {
            if (SortingOrder == true)
            {
                SortArrayByIncrease(array);
            }
            else 
            {
                SortArrayByDecrease(array);
            }
        }

        public static void SortArrayByIncrease(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMinValue = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexOfMinValue])
                    {
                        indexOfMinValue = j;
                    }
                }
                int temp = array[i];
                array[i] = array[indexOfMinValue];
                array[indexOfMinValue] = temp;
            }
        }
      
        public static void SortArrayByDecrease(int[] array)
        {
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMaxValue = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[indexOfMaxValue])
                    {
                        indexOfMaxValue = j;
                    }
                }
                int temp = array[i];
                array[i] = array[indexOfMaxValue];
                array[indexOfMaxValue] = temp;
            }
        }
    }
}
