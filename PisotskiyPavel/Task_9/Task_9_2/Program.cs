using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(2);
            myList.Add(25);
            myList.Add(23);
            myList.Add(1);
            myList.Add(722);

            Console.WriteLine("Количество элементов в списке: {0}", myList.Count);
            Console.WriteLine("Элементы списка: ");
            foreach (int num in myList)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
