using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_7
{
    public class ArrayList
    {
        private object[] array;

        public ArrayList() : this(0)
        {

        }

        public ArrayList(int capacity)
        {
            array = new object[capacity];
        }

        public object this[int index]
        {
            get
            {
                if (index > Count - 1 || index < 0)
                    throw new IndexOutOfRangeException();

                return array[index];
            }
        }

        public int Count { get; private set; }

        public int Add(object item)
        {
            if (array.Length == Count)
            {
                IncreaseArray();
            }

            array[Count] = item;
            ++Count;
            return Count - 1;
        }

        private void IncreaseArray()
        {
            int newLenght = array.Length == 0 ? 4 : array.Length * 2;
            object[] newArray = new object[newLenght];
            array.CopyTo(newArray, 0);
            array = newArray;
        }
    }
}
