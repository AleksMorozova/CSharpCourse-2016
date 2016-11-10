using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();
            cars.Add(new Car("Ford", 200, 30000));
            cars.Add(new Car("Toyota", 220, 40000));
            cars.Add(new Car("Mazda", 240, 35000));
            cars.Add(new SportCar("Ferrari", 380, 120000));
            foreach (Car car in cars)
            {
                car.PrintInfo();
            }
            Console.WriteLine("Cars count: {0}", cars.Count);
            cars.Clear();
            Console.WriteLine("Cars count: {0}", cars.Count);
            Console.ReadKey();
        }
    }
}
