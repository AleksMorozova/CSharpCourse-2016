using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Invoice
    {
        private const double nds = 18;
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;
        public string Article
        {
            set { article = value; }
        }
        public int Quantity
        {
            set { quantity = value; }
        }
        public double Price { get; set; }
        public double CostWithNDS
        {
            get { return GetCostWithNds(); }
        }
        public double CostWithoutNDS
        {
            get { return GetCostWithoutNds(); }
        }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        private double GetCostWithNds()
        {
            return quantity * Price; 
        }
        private double GetCostWithoutNds()
        {
            return quantity * Price * (100 - nds) / 100;
        }
        
    }
}
