using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MyDictionary
{
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>, IEnumerable, IEnumerator
    {
        private TValue[] values;
        private TKey[] keys;
        private int index;
        public int Count
        {
            get { return keys.Length; }
        }
        public object Current
        {
            get { return values[index]; }
        }
        public TValue this[int index]
        {
            get
            {
                TValue result = default(TValue);
                try
                {
                    result = values[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    Log.Write(e.Message);
                }
                return result;
            }
        }
        public TValue this[TKey key]
        {
            get
            {
                int index = GetKeyIndex(key);
                return index < 0 ? default(TValue) : values[index];
            }
        }
        public MyDictionary()
        {
            values = new TValue[0];
            keys = new TKey[0];
            index = -1;
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tmpKeys = new TKey[Count + 1];
            TValue[] tmpValues = new TValue[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                tmpKeys[i] = keys[i];
                tmpValues[i] = values[i];
            }
            tmpKeys[Count] = key;
            tmpValues[Count] = value;
            keys = tmpKeys;
            values = tmpValues;
        }
        public bool IsExist(TKey key)
        {
            return GetKeyIndex(key) >= 0;
        }
        public void Remove(TKey key)
        {
            TKey[] tmpKeys = new TKey[Count - 1];
            TValue[] tmpValues = new TValue[Count - 1];
            int k = 0;
            int index;
            if ((index = GetKeyIndex(key)) >= 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (index == i)
                    {
                        continue;
                    }
                    tmpKeys[k] = keys[i];
                    tmpValues[k] = values[i];
                    k++;
                }
                keys = tmpKeys;
                values = tmpValues;
            }
            else
            {
                Log.Write("Value with '{0}' key doesn't exist", key);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return values.GetEnumerator();
        }
        public void Reset()
        {
            index = -1;
        }
        public bool MoveNext()
        {
            bool hasMoved = false;
            if (++index > Count - 1)
            {
                Reset();
            }
            else
            {
                hasMoved = true;
            }
            return hasMoved;
        }
        private int GetKeyIndex(TKey key)
        {
            int result = -1;
            for (int i = 0; i < Count; i++)
            {                
                if (keys[i].Equals(key))
                {
                    result = i;
                }
            }
            return result;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                result.AppendFormat("Key->{0}: Value->{1}", keys[i], values[i]);
                if (i < Count - 1)
                {
                    result.Append(Environment.NewLine);
                }
            }
            return result.ToString();
        }
    }
}
