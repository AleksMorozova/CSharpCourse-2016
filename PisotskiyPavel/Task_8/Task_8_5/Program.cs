using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();
            cars.Add(new Car("BMW", 2011));
            cars.Add(new Car("Mercedes", 2005));
            cars.Add(new Car("Porsche", 2009));

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].Name + " - " + cars[i].IssueYear);
            }

            Console.ReadLine();
        }
    }
}
