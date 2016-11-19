using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_4
{
    class MyList<T>
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
        
    }
    static class Array
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] element_list = new T[list.Capacity];
            for (int i = 0; i < list.Capacity; i++)
            {
                element_list[i] = list[i];
            }
            return element_list;
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
            for (int i = 0; i < list.Capacity; i++)
            {
                Console.WriteLine(list[i]);
            }

            double[] element_list = Array.GetArray<double>(list);
            for (int i = 0; i < element_list.Length; i++)
            {
                Console.WriteLine(element_list[i]);
            }

            Console.ReadKey();
        }
        
    }
}
