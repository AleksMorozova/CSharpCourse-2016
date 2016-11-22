using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MyList
{
    public class MyList<T> : IMyList<T>, IEnumerable, IEnumerator
    {
        private T[] myList;
        private int index;
        public T this[int index]
        {
            get
            {
                T result = default(T);
                try
                {
                    result = myList[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    Log.Write(e.Message);
                }
                return result;
            }
        }
        public object Current
        {
            get { return myList[index]; }
        }
        public int Count
        {
            get { return myList.Length; }
        }
        public MyList()
        {
            myList = new T[0];
            index = -1;
        }
        public void Add(T item)
        {
            T[] tmpList = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                tmpList[i] = myList[i];
            }
            tmpList[Count] = item;
            myList = tmpList;
        }
        public bool RemoveAt(int indexElement)
        {
            bool hasRemoved = false;
            T[] tmpList = new T[Count - 1];
            int k = 0;
            try
            {
                for (int i = 0; i < Count; i++)
                {
                    if (i == indexElement)
                    {
                        hasRemoved = true;
                        continue;
                    }
                    tmpList[k++] = myList[i];
                }
                myList = tmpList;
            }
            catch (IndexOutOfRangeException e)
            {
                Log.Write(e.Message);
            }
            return hasRemoved;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                result.AppendFormat("List[{0}] = {1}", i, myList[i]);
                if (i < Count - 1)
                {
                    result.Append(Environment.NewLine);
                }
            }
            return result.ToString();
        }
        public IEnumerator GetEnumerator()
        {
            return myList.GetEnumerator();
        }
        public void Reset()
        {
            index = -1;
        }
        public bool MoveNext()
        {
            bool isMove = false;
            if (++index > Count-1)
            {
                Reset();
            }
            else
            {
                isMove = true;
            }
            return isMove;
        }
    }
}
