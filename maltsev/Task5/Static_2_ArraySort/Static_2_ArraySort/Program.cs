using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_2_ArraySort
{
    static class Array
    {
        static public void Sort(int[] arr)
        {
            for(int i=0; i< arr.Length-1; i++)
                for(int j = i+1; j < arr.Length; j++)
                    if (arr[i] < arr[j])
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                  
        }
        static public void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new Int32[] { 9, 4, 2, 7, 1 };

            Array.Sort(arr);
            Array.Show(arr);

            Console.ReadKey();
        }
    }
}
