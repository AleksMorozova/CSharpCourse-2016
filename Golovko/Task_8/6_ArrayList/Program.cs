using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("ArrayList");
            list.Add(2);
            list.Add(new Exception());
            list.Add(null);
            list.Add(33.5);
            ArrayList clone = (ArrayList)list.Clone();
            list.RemoveAt(2);
            Array array = new object[clone.Count];
            clone.CopyTo(array, 0);
            Console.WriteLine("array length {0}",array.Length);
            foreach (object obj in list)
            {
                Console.WriteLine(obj);
            }
            foreach (object obj in clone)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(array.GetValue(0));
            Console.ReadKey();
        }
    }
}
