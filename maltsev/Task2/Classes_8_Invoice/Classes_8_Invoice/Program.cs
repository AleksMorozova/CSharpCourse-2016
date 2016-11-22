using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_8_Invoice
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;
        private double nds;

        public int Account
        {
            get { return account; }
        }
        public string Customer
        {
            get { return customer; }
        }
        public string Provider
        {
            get { return provider; }
        }
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
        public double CostWithoutNDS
        {
            get { return CostCalculatorWithoutNDS(); }
        }
        public double CostWithNDS
        {
            get { return CostCalculatorWithNDS(); }
        }
        public Invoice(int a, string c, string p)
        {
            account = a;
            customer = c;
            provider = p;
            nds = 0.18;
        }
        private double CostCalculatorWithoutNDS()
        {
            return 12345 * quantity * (1 - nds);
        }
        private double CostCalculatorWithNDS()
        {
            return 12345 * quantity;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(34234, "Mr.Thompson", "Pepsi");
            invoice1.Article = "Water";
            invoice1.Quantity = 30000;
            Console.WriteLine("With NDS: {0}", invoice1.CostWithNDS);
            Console.WriteLine("Without NDS: {0}", invoice1.CostWithoutNDS);
            Console.ReadKey();
        }
    }
}
