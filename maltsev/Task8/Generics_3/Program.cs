using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_3
{
    class MyDictionary<TKey, TValue> where TKey: IComparable
    {
        private TKey[] keys;
        private TValue[] values;
        
        public int Capacity { get; private set; }

        public TValue this[TKey key]
        {
            get{
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(key))
                        return values[i];
                }
                return default(TValue);
            }
            set {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(key))
                        values[i] = value;
                }
            }
        }

        public MyDictionary()
        {
            Capacity = 0;
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] keys2 = new TKey[Capacity + 1];
            TValue[] values2 = new TValue[Capacity + 1];

            for (int i = 0; i < Capacity; i++)
            {
                keys2[i] = keys[i];
                values2[i] = values[i];
            }

            keys = keys2;
            keys[Capacity] = key;

            values = values2;
            values[Capacity] = value;

            Capacity++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,int> dic = new MyDictionary<int,int>();
            dic.Add(2, 190);
            dic.Add(5, 2990);
            dic.Add(6, 12345);
            Console.WriteLine(dic[2]);
            Console.WriteLine(dic[5]);
            Console.WriteLine(dic[6]);
            Console.WriteLine(dic.Capacity);
            Console.ReadKey();
        }
    }
}
