using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myClass = new MyList<int>(2);
            myClass.Add(25);
            myClass.Add(23);
            myClass.Add(1);
            myClass.Add(722);

            Console.WriteLine("Количество элементов в списке: {0}", myClass.Count);
            Console.WriteLine("Элементы списка: ");
            for (int i = 0; i < myClass.Count; i++)
            {
                Console.WriteLine(myClass[i]);
            }

            Console.ReadLine();
        }
    }
}
