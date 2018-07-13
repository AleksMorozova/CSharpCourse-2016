using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_9_CurrencyConverter
{
    static class CurrencyConverter
    {
        private static List<Currency> currencies = new List<Currency>();

        static CurrencyConverter()
        {
            currencies.Add(new Currency()
            {
                From = Currencies.UAH,
                To = Currencies.USD,
                Rate = 0.038767
            });

            currencies.Add(new Currency()
            {
                From = Currencies.USD,
                To = Currencies.UAH,
                Rate = 25.795135
            });

            currencies.Add(new Currency()
            {
                From = Currencies.UAH,
                To = Currencies.EUR,
                Rate = 0.035161855
            });

            currencies.Add(new Currency()
            {
                From = Currencies.EUR,
                To = Currencies.UAH,
                Rate = 28.4399102
            });

            currencies.Add(new Currency()
            {
                From = Currencies.EUR,
                To = Currencies.USD,
                Rate = 1.10253
            });

            currencies.Add(new Currency()
            {
                From = Currencies.USD,
                To = Currencies.EUR,
                Rate = 0.907004798
            });
        }

        public static double Convert(double amount, Currencies from, Currencies to)
        {
            Currency currency = currencies.Where(cur => cur.From == from && cur.To == to).First();
            return amount * currency.Rate;
        }

        

        
    }
}
