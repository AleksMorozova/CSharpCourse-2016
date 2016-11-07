using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ArraySortAscDesc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 33, 4, 9, 10, 5, 8, 16 };            
            array.Sort(SortType.ASC).Print();
            array.Sort(SortType.DESC).Print();
            Console.ReadKey();
        }
    }
}
