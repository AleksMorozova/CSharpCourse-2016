using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ArrayToCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {2, -6, -4, 14, 3, -6, -11, 4, 31 };
            var collection = Collection.ArrayToCollection(array);
            foreach (var el in collection)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}
