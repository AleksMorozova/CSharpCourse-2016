using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(102115, "Golovko Greg", "CE ABC");
            invoice.Article = "Rope jumping";
            invoice.Price = 400;
            invoice.Quantity = 3;
            Console.WriteLine("Cost without NDS is {0} uah\nCost with NDS is {1} uah", invoice.CostWithoutNDS, invoice.CostWithNDS);
            Console.ReadKey();
        }
    }
}
