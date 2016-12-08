using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        int count;
        TKey[] keys;
        TValue[] values;


        public int Count
        {
            get { return count; }
        }
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
            count = 0;
        }

        public void Add(TKey enteredKey, TValue enteredValue)
        {
            TKey[] temporaryKeys = new TKey[count + 1];
            TValue[] temporaryValues = new TValue[count + 1];
            for (int i = 0; i < count; i++)
            {
                temporaryKeys[i] = keys[i];
                temporaryValues[i] = values[i];
            }
            temporaryKeys[count] = enteredKey;
            temporaryValues[count] = enteredValue;
            keys = temporaryKeys;
            values = temporaryValues;
            count++;
        }

        public TValue this[TKey index]
        {
            get
            {
                return FindValueByKey(index);
            }
        }

        TValue FindValueByKey(TKey index)
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i].Equals(index))
                {
                    return values[i];
                }
            }
            return default(TValue);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }            
        }

    }
}
