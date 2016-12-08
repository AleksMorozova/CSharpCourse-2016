using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4GetArray
{
    static class MyListExtension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] result = new T[2];
            return result;
        }
    }
}
