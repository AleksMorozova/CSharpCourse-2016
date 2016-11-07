using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Invoice
    {
        private readonly int nds = 7;
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;

        public double Price { get; set; }

        public string Article
        {
            set { article = value; }
        }

        public int Quantity
        {
            set { quantity = value; }
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void Cost()
        {
            double costwithnds = quantity * Price * (100 - 7) / 100;
            double cost = quantity * Price;

            Console.WriteLine("\nPrice with NDS: {0}", costwithnds);
            Console.WriteLine("Price without NDS: {0}", cost);
        }
    }
}
