using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2SortExtension
{
    public static class MyIntArrayExtension
    {

        public static void SortArrayByIncrease(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
			{
                int indexOfMinValue = i;
			    for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[indexOfMinValue])
                    {
                       indexOfMinValue = j; 
                    }               
                }
			    int temp = array[i];
                array[i] = array[indexOfMinValue];
                array[indexOfMinValue] = temp;
			}           
        }

    }
}
