using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_MyList;

namespace _4_ExtendedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(7);
            list.Add(18);
            list.Add(6);
            Console.WriteLine(list.ToString());
            int[] array = list.GetArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
            Console.ReadKey();
        }
    }
}
