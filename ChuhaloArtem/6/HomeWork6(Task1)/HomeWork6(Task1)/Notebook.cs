using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_Task1_
{
    struct Notebook
    {
        string model;
        string produser;
        double price;

        public Notebook(string model, string produser, double price)
        {
            this.model = model;
            this.produser = produser;
            this.price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Produser: {0}", produser);
            Console.WriteLine("Price: {0}", price);
        }
    }
}
