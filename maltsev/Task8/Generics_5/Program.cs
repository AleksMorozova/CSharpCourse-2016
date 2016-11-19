using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_5
{
    class Car
    {
        public string Name { get; private set; }
        public int Year { get; private set; }

        public Car()
        {
            Name = "";
            Year = 0;
        }
        public Car(string name, int year)
        {
            Name = name;
            Year = year;
        }
        public override string ToString()
        {
            string str = "Name:\t" + Name.ToString() + "\n" +
                "Year:\t" + Year.ToString();
            return str;
        }
    }
    class CarCollection<T> where T: Car
    {
        private T[] cars;
        public int Capacity { get; private set; }

        public T this[int index]
        {
            get
            {
                return cars[index];
            }
        }
        public CarCollection()
        {
            Capacity = 0;
        }
        public void Add(T car)
        {
            T[] carsTemp = new T[Capacity+1];
            for (int i = 0; i < Capacity; i++)
            {
                carsTemp[i] = cars[i];
            }
            carsTemp[Capacity] = car;
            cars = carsTemp;
            Capacity++;
        }
        public void Delete()
        {
            cars = new T[0];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> park = new CarCollection<Car>();
            park.Add(new Generics_5.Car("Audi", 1998));
            park.Add(new Generics_5.Car("Ford", 2007));
            park.Add(new Generics_5.Car("BMW", 2015));
            Console.WriteLine(park[2]);
            park.Delete();
            Console.ReadKey();
        }
    }
}
