using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_MyList;

namespace _4_ExtendedMethod
{
    static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            int k = 0;
            foreach (T element in list)
            {
                array[k++] = element;
            }
            return array;
        }
    }
}
