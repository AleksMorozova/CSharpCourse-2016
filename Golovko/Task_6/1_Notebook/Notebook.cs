using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Notebook
{
    struct Notebook
    {
        private readonly string model;
        private readonly string factory;
        private readonly double price;
        public Notebook(string model, string factory, double price)
        {
            this.model = model;
            this.factory = factory;
            this.price = price;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Factory: {0}", factory);
            Console.WriteLine("Price: {0}$", price);
        }
    }
}
