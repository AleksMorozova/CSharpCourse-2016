using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Notebook
{
    struct Notebook
    {
        string manufacturer;
        string model;
        double price;      

        public Notebook(string manufacturer, string model, double price )
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            
        }

        public void ShowInfo()
        {
            Console.WriteLine("Information about notebook: ");
            Console.WriteLine("manufacturer: " + manufacturer);
            Console.WriteLine("model: " + model);
            Console.WriteLine("price: {0}$", price);
        }
    }
}
