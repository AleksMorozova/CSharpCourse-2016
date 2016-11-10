using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_MyList;

namespace _4_MyListExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("My");
            myList.Add("List");
            myList.Add("Collection");
            var array = MyListExtension.GetArray(myList);
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
