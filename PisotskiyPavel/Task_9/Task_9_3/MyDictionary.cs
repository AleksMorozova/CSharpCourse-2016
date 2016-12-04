using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_9_3;

namespace Task_9_3
{
    class MyDictionary<TKey, TValue> : IEnumerable<MyKeyValuePair<TKey, TValue>>
    {
        MyKeyValuePair<TKey, TValue>[] items;

        public MyDictionary(int capacity)
        {
            items = new MyKeyValuePair<TKey, TValue>[capacity];
        }

        public MyDictionary() : this(0)
        {

        }

        public int Count { get; private set; }

        public void Add(TKey key, TValue value)
        {
            if (items.Length == Count)
            {
                IncreaseArray();
            }

            items[Count] = new MyKeyValuePair<TKey, TValue>(key, value);
            Count++;
        }

        private void IncreaseArray()
        {
            int newLenght = items.Length == 0 ? 4 : items.Length * 2;

            MyKeyValuePair<TKey, TValue>[] newItems = new MyKeyValuePair<TKey, TValue>[newLenght];

            items.CopyTo(newItems, 0);

            items = newItems;
        }

        public IEnumerator<MyKeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public MyKeyValuePair<TKey, TValue> this[int index]
        {
            get
            {
                if (index > Count - 1 || index < 0)
                    throw new IndexOutOfRangeException();

                return items[index];
            }
        }
    }
}
