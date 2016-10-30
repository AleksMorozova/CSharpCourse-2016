using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_3_ArraySortBool
{
    static class Array
    {
        static public void Sort(int[] arr, bool flag )
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] > arr[j]) && flag)
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                    if((arr[i] < arr[j]) && !flag)
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
                    

        }
        static public void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new Int32[] { 3, 5, 1, 11, 7 };
            Array.Show(arr);
            Console.WriteLine();

            Array.Sort(arr, true);
            Array.Show(arr);
            Console.WriteLine();

            Array.Sort(arr, false);
            Array.Show(arr);

            Console.ReadKey();
        }
    }
}
