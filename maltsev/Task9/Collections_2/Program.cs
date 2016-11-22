using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    class MyList<T>: IEnumerable<T>
    {
        private T[] elements;

        public int Capacity { get; private set; }

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        public MyList()
        {
            Capacity = 0;
        }
        public void Add(T elem)
        {
            T[] elements2 = new T[Capacity + 1];
            for (int i = 0; i < Capacity; i++)
            {
                elements2[i] = elements[i];
            }
            elements = elements2;
            elements[Capacity] = elem;
            Capacity++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                yield return elements[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<double> list = new MyList<double>();
            list.Add(234.1);
            list.Add(2222.11);
            list.Add(343.222);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
