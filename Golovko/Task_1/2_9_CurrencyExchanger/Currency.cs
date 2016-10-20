using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_CurrencyExchanger
{
    class Currency : ICurrency
    {
        public string Name { get; }
        public double Buy { get; }
        public double Sell { get; }
        public Currency(string name, double buy, double sell)
        {
            this.Name = name;
            this.Buy = buy;
            this.Sell = sell;
        }
    }
}
