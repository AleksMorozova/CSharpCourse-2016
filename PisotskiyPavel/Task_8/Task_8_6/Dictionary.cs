using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_6
{
    class Dictionary<TKey, TValue>
    {
        KeyValuePair<TKey, TValue>[] items;

        public Dictionary(int capacity)
        {
            items = new KeyValuePair<TKey, TValue>[capacity];
        }

        public Dictionary() : this(0)
        {

        }

        public int Count { get; private set; }

        public void Add(TKey key, TValue value)
        {
            if (items.Length == Count)
            {
                IncreaseArray();
            }

            items[Count] = new KeyValuePair<TKey, TValue>(key, value);
            Count++;
        }

        private void IncreaseArray()
        {
            int newLenght = items.Length == 0 ? 4 : items.Length * 2;

            KeyValuePair<TKey, TValue>[] newItems = new KeyValuePair<TKey, TValue>[newLenght];

            items.CopyTo(newItems, 0);

            items = newItems;
        }

        public KeyValuePair<TKey, TValue> this[int index]
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
