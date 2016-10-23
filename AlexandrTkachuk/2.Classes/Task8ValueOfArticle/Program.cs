using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8ValueOfArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1234, "Alexander", "Nova Poshta");
            invoice.CalculateOrder("Pen", 1, 50);
            invoice.ShowValueOfOrder();
        }
    }
}
