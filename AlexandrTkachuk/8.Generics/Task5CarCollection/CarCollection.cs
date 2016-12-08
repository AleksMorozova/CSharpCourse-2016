using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5CarCollection
{
    class CarCollection<T>
    {
        List<T> cars;
        int count;

        public int Count
        {
            get { return count; }
        }

        public CarCollection()
        {
            cars = new List<T>();
            count = cars.Count;
        }

        public void Add(T car)
        {
            cars.Add(car);
            count++;
        }

        public void Clear()
        {
            cars.Clear();
            count = 0;
        }

        public T this[int index]
        {
            get { return cars[index]; }
        }

    }
}
