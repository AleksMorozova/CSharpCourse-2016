using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CarCollection
{
    class CarCollection<T> : ICarCollection<T>, IEnumerable, IEnumerator where T : Car
    {
        private T[] cars;
        private int index;
        public int Count
        {
            get { return cars.Length; }
        }
        public T this[int index]
        {
            get
            {
                T result = default(T);
                try
                {
                    result = cars[index];
                }
                catch(IndexOutOfRangeException e)
                {
                    Log.Write(e.Message);
                }
                return cars[index];
            }
        }
        public object Current
        {
            get { return cars[index]; }
        }
        public CarCollection()
        {
            cars = new T[0];
            index = -1;
        }
        public void Add(T car)
        {
            T[] tmpCars = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                tmpCars[i] = cars[i];
            }
            tmpCars[Count] = car;
            cars = tmpCars;
        }
        public void Clear()
        {
            cars = new T[0];
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public void Reset()
        {
            index = -1;
        }
        public bool MoveNext()
        {
            bool hasMoved = false;
            if (++index > Count - 1)
            {
                Reset();
            }
            else
            {
                hasMoved = true;
            }
            return hasMoved;
        }
    }
}
