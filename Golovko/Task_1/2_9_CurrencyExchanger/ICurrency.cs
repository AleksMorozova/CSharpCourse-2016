using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_CurrencyExchanger
{
    interface ICurrency
    {
        string Name { get; }
        double Sell { get; }
        double Buy { get; }
    }
}
