using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4GetArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> stringList = new MyList<string>();
            stringList.Add("First");
            stringList.Add("Second");
            stringList.Add("Third");

            string [] result = stringList.GetArray<string>();
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
