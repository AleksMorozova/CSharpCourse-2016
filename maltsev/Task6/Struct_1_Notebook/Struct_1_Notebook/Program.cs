using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_1_Notebook
{
    struct Notebook
    {
        private string model;
        private string producer;
        private double price;
        public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine("Model: \t\t" + model);
            Console.WriteLine("Producer:\t" + producer);
            Console.WriteLine("Price: \t\t" + price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook nb = new Notebook("RedArt", "Germany", 12.5);
            nb.Show();
            Console.ReadKey();
        }
    }
}
