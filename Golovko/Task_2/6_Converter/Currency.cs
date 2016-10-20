using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Converter
{
    struct Currency
    {
        public Symbol Symbol { get; set; }
        public double Price { get; set; }
        public Currency(Symbol symbol, double price)
        {
            this.Symbol = symbol;
            this.Price = price;
        }
    }
}
