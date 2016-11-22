using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            Console.WriteLine("Add keys and values to myDictionary:");
            myDictionary.Add("first key", "first value");
            myDictionary.Add("second key", "second value");
            myDictionary.Add("third key", "third value");
            Console.WriteLine(myDictionary.ToString());
            Console.WriteLine("Removing element with key 'second key'");
            Console.WriteLine("Enumerating elements in foreach cycle:");
            myDictionary.Remove("second key");
            foreach (string value in myDictionary)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Getting element with 'third key' key:");
            Console.WriteLine(myDictionary["third key"]);
            Console.ReadKey();
        }
    }
}
