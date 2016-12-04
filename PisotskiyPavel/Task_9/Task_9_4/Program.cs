using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_9_2;

namespace Task_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myClass = new MyList<int>();
            myClass.Add(25);
            myClass.Add(23);
            myClass.Add(1);
            myClass.Add(722);
            myClass.Add(-453);
            myClass.Add(0);

            int[] array = myClass.GetArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
