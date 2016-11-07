using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StringExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string str ="Hello .NET";
            Console.WriteLine(str.Substring(startIndex: 6, countChars: 4));
            Console.WriteLine(str.IndexOf(stringValue: ".NET"));
            Console.WriteLine(str.Replace(oldValue: "HELLO", replaceValue: "CLR"));
            Console.ReadKey();
            
        }
    }
}
