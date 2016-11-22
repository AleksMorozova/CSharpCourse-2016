using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MyList
{
    interface IMyList<T>
    {
        void Add(T item);
        T this[int index] { get; }
        int Count { get; }
    }
}
