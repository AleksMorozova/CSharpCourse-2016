using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (var item in EvenNum(arr))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static IEnumerable<int> EvenNum(int[] arr)
        {
            foreach (var i in arr)
            {
                if (i%2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
