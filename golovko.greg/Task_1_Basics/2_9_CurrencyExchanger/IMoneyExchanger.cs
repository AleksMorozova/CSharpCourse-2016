using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_CurrencyExchanger
{
    interface IMoneyExchanger
    {
        void Add(Currency currency);
        void Exchange(Currency currency, double volume, Type type);
        Currency GetCurrencyByName(string name);
    }
}
