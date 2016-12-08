using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4MyStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string line2 = MyString.Substring("12345678", 2, 3);
            Console.WriteLine(line2);
            Console.WriteLine(MyString.IndexOf("12345678", "456"));
            string str = MyString.Replace("12345672389000002300", "23", "a");
            Console.WriteLine(str);
        }
    }
}
