using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            Console.WriteLine("Adding elements to myList:");
            myList.Add("My");
            myList.Add("List");
            myList.Add("Collection");
            Console.WriteLine("Get info of myList's elements:");
            Console.WriteLine(myList.ToString());
            Console.WriteLine("Get element's value with index '2': {0}", myList[2]);
            Console.WriteLine("Remove element with index '1':");
            myList.RemoveAt(1);
            Console.WriteLine("Enumerate the collection in foreach cycle:");
            foreach (string element in myList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
