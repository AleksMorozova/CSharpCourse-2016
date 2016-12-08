using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(12);
            myList.Add("Text");
            myList.Add('!');

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
