using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_7
{
    class ArrayList
    {
        private object[] arr;
        public int Size { get; private set; }
        public int UsedSize { get; private set; }

        public ArrayList()
        {
            Size = 10;
            arr = new object[Size];
        }
        public void Add(object elem)
        {
            if (Size == UsedSize)
            {
                object[] arrTemp = new object[UsedSize + 10];
                for (int i = 0; i < Size; i++)
                {
                    arrTemp[i] = arr[i];
                }
                arrTemp[UsedSize] = elem;
                arr = arrTemp;
                Size = Size + 10;
            }
            else
            {
                arr[UsedSize] = elem;
                UsedSize++;
            }
        }
        public void Remove(object elem)
        {
            for (int i = 0; i < UsedSize; i++)
            {
                if( arr[i] == elem)
                {
                    for (int j = i; j < UsedSize; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    UsedSize--;
                    break;
                }
            }

        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < UsedSize; i++)
            {
                arr[i] = arr[i + 1];
            }
            UsedSize--;
        }
        public void Clear()
        {
            arr = new object[0];
        }
        public int IndexOf(object elem)
        {
            for (int i = 0; i < UsedSize; i++)
            {
                if (arr[i] == elem)
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < UsedSize; i++)
            {
                str += i.ToString() + ":\t" + arr[i].ToString() + "\n";
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();

            alist.Add(342);
            alist.Add(34643.3);
            alist.Add("dsjf");
            alist.Add(true);
            Console.WriteLine(alist);

            Console.WriteLine("Index of dsjf: " + alist.IndexOf("dsjf")+ "\n");

            alist.RemoveAt(2);
            Console.WriteLine(alist);

            Console.ReadKey();
        }
    }
}
