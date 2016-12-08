using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4MyListExtension
{
    class MyList<T>
    {
        int count;
        T[] items;

        public int Count
        {
            get { return count; }
        }

        public MyList()
        {
            items = new T[0];
            count = 0;
        }
        public MyList(int size)
        {

            count = size;
            items = new T[count];
            for (int i = 0; i < size - 1; i++)
            {
                items[i] = default(T);
            }
        }

        public void Add(T enteredItem)
        {
            T[] temporaryArray = new T[count + 1];
            for (int i = 0; i < count; i++)
            {
                temporaryArray[i] = items[i];
            }
            temporaryArray[count] = enteredItem;
            items = temporaryArray;
            count++;
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
        }
    }
}
