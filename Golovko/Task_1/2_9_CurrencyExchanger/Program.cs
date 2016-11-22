using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_CurrencyExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            IMoneyExchanger exchanger = new MoneyExchanger();
            exchanger.Add(new Currency("UAH", 1, 1));
            exchanger.Add(new Currency("USD", 26.11, 26.38));
            exchanger.Add(new Currency("EUR", 29.25, 29.52));
            Console.WriteLine("Enter the currency (UAH, USD, EUR):");
            Currency baseCurrency = exchanger.GetCurrencyByName(Console.ReadLine());
            if (baseCurrency == null)
                Console.WriteLine("Currency isn't exist");
            else
            {
                Console.WriteLine("Enter the volume:");
                double volume = double.Parse(Console.ReadLine());
                exchanger.Exchange(baseCurrency, volume, Type.Sell);
            }
            Console.ReadKey();
        }
    }
}
