using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
    class Converter
    {
        private readonly double usd, eur, rub;
        private readonly List<Currency> currencies = new List<Currency>();


        /// <summary>
        /// Initializes a new instance of the class Converter, which is used for currency conversion
        /// </summary>
        /// <param name="usd">Value of 1 USD in UAH</param>
        /// <param name="eur">Value of 1 EUR in UAH</param>
        /// <param name="rub">Value of 1 RUB in UAH</param>
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;

            CurrencyInit();
        }

        private void CurrencyInit()
        {
            #region FromUAH
            currencies.Add(new Currency()
            {
                From = Currencies.UAH,
                To = Currencies.USD,
                Rate = 1 / usd
            });

            currencies.Add(new Currency()
            {
                From = Currencies.UAH,
                To = Currencies.EUR,
                Rate = 1 / eur
            });

            currencies.Add(new Currency()
            {
                From = Currencies.UAH,
                To = Currencies.RUB,
                Rate = 1 / rub
            });

            currencies.Add(new Currency()
            {
                From = Currencies.UAH,
                To = Currencies.UAH,
                Rate = 1
            });
            #endregion
            #region FromRUB
            currencies.Add(new Currency()
            {
                From = Currencies.RUB,
                To = Currencies.USD,
                Rate = rub / usd
            });

            currencies.Add(new Currency()
            {
                From = Currencies.RUB,
                To = Currencies.EUR,
                Rate = rub / eur
            });

            currencies.Add(new Currency()
            {
                From = Currencies.RUB,
                To = Currencies.RUB,
                Rate = 1
            });

            currencies.Add(new Currency()
            {
                From = Currencies.RUB,
                To = Currencies.UAH,
                Rate = rub 
            });
            #endregion
            #region FromEUR
            currencies.Add(new Currency()
            {
                From = Currencies.EUR,
                To = Currencies.USD,
                Rate = eur / usd
            });

            currencies.Add(new Currency()
            {
                From = Currencies.EUR,
                To = Currencies.EUR,
                Rate = 1
            });

            currencies.Add(new Currency()
            {
                From = Currencies.EUR,
                To = Currencies.RUB,
                Rate = eur / rub
            });

            currencies.Add(new Currency()
            {
                From = Currencies.EUR,
                To = Currencies.UAH,
                Rate = eur
            });
            #endregion
            #region FromUSD
            currencies.Add(new Currency()
            {
                From = Currencies.USD,
                To = Currencies.USD,
                Rate = 1
            });

            currencies.Add(new Currency()
            {
                From = Currencies.USD,
                To = Currencies.EUR,
                Rate = usd / eur
            });

            currencies.Add(new Currency()
            {
                From = Currencies.USD,
                To = Currencies.RUB,
                Rate = usd / rub
            });

            currencies.Add(new Currency()
            {
                From = Currencies.USD,
                To = Currencies.UAH,
                Rate = usd
            });
            #endregion
        }

        public double Convert(double amount, Currencies from, Currencies to)
        {
            Currency currency = this.currencies.Where(cur => cur.From == from && cur.To == to).First();
            return amount * currency.Rate;
        }
    }
}
