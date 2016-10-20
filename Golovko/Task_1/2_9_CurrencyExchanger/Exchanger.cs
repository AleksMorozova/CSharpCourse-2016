using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_CurrencyExchanger
{
    static class Exchanger
    {
        public static double Exchange(Currency currencyFrom, Currency currencyTo, double volume, Type type)
        {
            return type > 0 ? volume * currencyFrom.Buy / currencyTo.Buy : volume * currencyFrom.Sell / currencyTo.Sell;
        }
    }
}
