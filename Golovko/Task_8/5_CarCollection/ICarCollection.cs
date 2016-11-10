using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CarCollection
{
    interface ICarCollection<T>
    {
        void Add(T car);
        int Count { get; }
        T this[int index] { get; }
        void Clear();
    }
}
