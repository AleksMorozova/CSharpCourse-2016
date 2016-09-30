using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_CurrencyExchanger
{
    class MoneyExchanger : IMoneyExchanger
    {
        private readonly List<Currency> currencies;
        public MoneyExchanger()
        {
            currencies = new List<Currency>();
        }
        public void Add(Currency currency)
        {
            currencies.Add(currency);
        }
        public void Exchange(Currency currency, double volume, Type type)
        {
            foreach (Currency curr in currencies)
            {
                if (currency.Name == curr.Name) continue;
                Console.WriteLine("{0} -> {1} = {2}", currency.Name, curr.Name, Exchanger.Exchange(currency, curr, volume, type));
            }
        }
        public Currency GetCurrencyByName(string name)
        {
            Currency resCurrency = null;
            foreach (Currency currency in currencies)
            {
                if (currency.Name == name) resCurrency = currency;
            }
            return resCurrency;
        }


    }
}
