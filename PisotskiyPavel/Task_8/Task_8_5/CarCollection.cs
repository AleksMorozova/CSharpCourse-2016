using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_5
{
    public class CarCollection<T> where T : Car
    {
        private T[] array;

        public CarCollection() : this(0)
        {

        }

        public CarCollection(int capacity)
        {
            array = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index > Count - 1 || index < 0)
                    throw new IndexOutOfRangeException();

                return array[index];
            }
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (array.Length == Count)
            {
                IncreaseArray();
            }

            array[Count] = item;
            ++Count;
        }

        private void IncreaseArray()
        {
            int newLenght = array.Length == 0 ? 4 : array.Length * 2;
            T[] newArray = new T[newLenght];
            array.CopyTo(newArray, 0);
            array = newArray;
        }
    }
}
