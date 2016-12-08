using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();
            intList.Add(6);
            intList.Add(7);
            intList.Add(8);
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("{0} элемент: {1}", i, intList[i]);
            }

            Console.WriteLine();

            MyList<string> stringList = new MyList<string>();
            stringList.Add("First");
            stringList.Add("Second");
            stringList.Add("Third");
            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine("{0} элемент: {1}", i, stringList[i]);
            }
        }
    }
}
