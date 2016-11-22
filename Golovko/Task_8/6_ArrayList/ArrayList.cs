using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ArrayList
{
    sealed class ArrayList : IList, ICollection, IEnumerable, ICloneable
    {
        private object[] list;
        public int Count
        {
            get { return list.Length; }
        }
        public object this[int index]
        {
            get
            {
                object result = default(object);
                try
                {
                    result = list[index];
                }
                catch (IndexOutOfRangeException e)
                {
                    Log.Write(e.Message);
                }
                return result;
            }
            set
            {
                try
                {
                    list[index] = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    Log.Write(e.Message);
                }
            }
        }
        public bool IsReadOnly { get; }
        public bool IsFixedSize { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
        public ArrayList()
        {
            list = new object[0];
            this.IsFixedSize = false;
            this.IsReadOnly = false;
            this.IsSynchronized = false;
            this.SyncRoot = this;
        }
        public int Add(object value)
        {
            int index = Count;
            object[] tmpList = new object[index + 1];
            for (int i = 0; i < index; i++)
            {
                tmpList[i] = list[i];
            }
            tmpList[index] = value;
            list = tmpList;
            return index;
        }
        public bool Contains(object value)
        {
            bool hasContained = false;
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(value))
                {
                    hasContained = true;
                    break;
                }
            }
            return hasContained;
        }
        public void Clear()
        {
            list = new object[0];
        }
        public int IndexOf(object value)
        {
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void Insert(int index, object value)
        {
            object[] tmpList = new object[Count + 1];
            int k = 0;
            try
            {
                for (int i = 0; i < Count; i++)
                {
                    if (index == i)
                    {
                        tmpList[k++] = value;
                    }
                    tmpList[k++] = list[i];
                }
                list = tmpList;
            }
            catch (IndexOutOfRangeException e)
            {
                Log.Write(e.Message);
            }
        }
        public void Remove(object value)
        {
            object[] tmpList = new object[Count - 1];
            int k = 0;
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(value))
                {
                    continue;
                }
                tmpList[k++] = list[i];
            }
            list = tmpList;
        }
        public void RemoveAt(int index)
        {
            object[] tmpList = new object[Count - 1];
            int k = 0;
            try
            {
                for (int i = 0; i < Count; i++)
                {
                    if (index == i)
                    {
                        continue;
                    }
                    tmpList[k++] = list[i];
                }

                list = tmpList;
            }
            catch (IndexOutOfRangeException e)
            {
                Log.Write(e.Message);
            }
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
        public void CopyTo(Array array, int index)
        {
            int k = 0;
            try
            {
                for (int i = index; i < Count; i++)
                {
                    array.SetValue(list[i], k++);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Log.Write(e.Message);
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
