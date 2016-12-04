using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_6
{
    struct KeyValuePair<TKey, TValue>
    {
        public KeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; private set; }
        public TValue Value { get; private set; }
    }
}
