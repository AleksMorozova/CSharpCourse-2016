using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MyDictionary
{
    interface IMyDictionary<TKey, TValue>
    {
        void Add(TKey key, TValue value);
        TValue this[int index] { get; }
        int Count { get; }
    }
}
