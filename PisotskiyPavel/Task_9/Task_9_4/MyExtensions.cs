using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9_4
{
    static class MyExtensions
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];
            int index = 0;
            foreach (T item in list)
            {
                array[index] = item;
                index++;
            }
            return array;
        }
    }
}
