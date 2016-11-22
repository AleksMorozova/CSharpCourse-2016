using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Converter
{
    class Converter
    {
        private readonly Currency usd;
        private readonly Currency eur;
        private readonly Currency rub;
        private readonly Currency uah;
        private readonly List<Currency> curencies;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = new Currency(Symbol.USD, usd);
            this.eur = new Currency(Symbol.EUR, eur);
            this.rub = new Currency(Symbol.RUB, rub);
            this.uah = new Currency(Symbol.UAH, 1);
            curencies = new List<Currency>();
            this.CurrenciesInit();
        }
        private void CurrenciesInit()
        {
            curencies.Add(usd);
            curencies.Add(eur);
            curencies.Add(rub);
            curencies.Add(uah);
        }
        private Currency GetCurrency(Symbol symbol)
        {
            return curencies.First(currency => currency.Symbol == symbol);
        }
        public double Convert(double sum, Symbol symbolFrom, Symbol symbolTo)
        {
            return sum * GetCurrency(symbolTo).Price / GetCurrency(symbolFrom).Price;            
        }
    }
}
