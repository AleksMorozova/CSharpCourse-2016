using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_1
{
    struct Notebook
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public Notebook(string model, string manufacturer, double price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Модель: {0}", Model);
            Console.WriteLine("Производитель: {0}", Manufacturer);
            Console.WriteLine("Цена: {0}$", Price);
        }
    }
}
