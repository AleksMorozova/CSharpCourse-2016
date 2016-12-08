using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> AutoPark = new CarCollection<Car>();
            AutoPark.Add(new Car("Toyota Corolla",2010));
            AutoPark.Add(new Car("Mazda 3", 2011));
            AutoPark.Add(new Car("Toyota RAV4", 2012));

            for (int i = 0; i < AutoPark.Count; i++)
            {
                Console.WriteLine("{0}  {1}",AutoPark[i].Name, AutoPark[i].YearOfCreating);
            }

            AutoPark.Clear();
        }
    }
}
