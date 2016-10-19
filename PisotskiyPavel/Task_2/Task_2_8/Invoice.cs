using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_8
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer, provider;
        private string article;
        private int quantity;
        private double nds = 0.18;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public int Account { get { return account; } }
        public string Customer { get { return customer; } }
        public string Provider { get { return provider; } }
        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Price { get; set; }
        
        public double CostWithoutNds()
        {
            return Price * Quantity;
        }

        public double CostWithNds()
        {
            return CostWithoutNds() - (CostWithoutNds() * nds);
        }
    }
}
