using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8ValueOfArticle
{
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;
        double valueOfOrder;
        double valueOfNDS;
        static double NDSCoefficient = 0.20;

        public Invoice(int account, string customer, string provider)
        { 
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void CalculateOrder(string article, int valueOfArticle, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
            CalculateValueOfOrder(valueOfArticle);
            CalculateNDS();
        }
        void CalculateValueOfOrder(int valueOfArticle)
        {
            valueOfOrder = valueOfArticle * quantity;
        }

        void CalculateNDS()
        {
            valueOfNDS =  valueOfOrder * NDSCoefficient;
        }

        public void ShowValueOfOrder()
        {
            Console.WriteLine("Information about order:");
            Console.WriteLine("account: {0}\ncustomer: {1}", account, customer);
            Console.WriteLine("provider: {0}\narticle: {1}", provider, article);
            Console.WriteLine("quantity: {0}\nvalue of order without NDS: {1}$", quantity, valueOfOrder);
            Console.WriteLine("value of order with NDS: {0}$", valueOfOrder + valueOfNDS);
        }
    }
}
