using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_9_CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите валюту, которую хотите перевести: UAH, EUR, USD");
            string selectedCurrency = Console.ReadLine().ToUpper();
            Console.WriteLine("Введите необходимую сумму:");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (selectedCurrency.Equals("UAH"))
            {
                Console.WriteLine("{0} UAH = {1} USD", amount, CurrencyConverter.Convert(amount, Currencies.UAH, Currencies.USD));
                Console.WriteLine("{0} UAH = {1} EUR", amount, CurrencyConverter.Convert(amount, Currencies.UAH, Currencies.EUR));
            }
            else if (selectedCurrency.Equals("USD"))
            {
                Console.WriteLine("{0} USD = {1} UAH", amount, CurrencyConverter.Convert(amount, Currencies.USD, Currencies.UAH));
                Console.WriteLine("{0} USD = {1} EUR", amount, CurrencyConverter.Convert(amount, Currencies.USD, Currencies.EUR));
            }
            else if (selectedCurrency.Equals("EUR"))
            {
                Console.WriteLine("{0} EUR = {1} UAH", amount, CurrencyConverter.Convert(amount, Currencies.EUR, Currencies.UAH));
                Console.WriteLine("{0} EUR = {1} USD", amount, CurrencyConverter.Convert(amount, Currencies.EUR, Currencies.USD));
            }

            Console.ReadLine();
        }

        
    }
}
