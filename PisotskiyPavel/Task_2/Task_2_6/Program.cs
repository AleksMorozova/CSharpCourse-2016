using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Из какой валюты вы хотите перевести: UAH, EUR, USD, RUB? ");
            string from = Console.ReadLine();
            Console.Write("В какую валюты вы хотите перевести: UAH, EUR, USD, RUB? ");
            string to = Console.ReadLine();
            Console.Write("Введите сумму, необходимую для перевода: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Converter currencyConverter = new Converter(25.6502334, 28.1921715, 0.409172523);
            double result = currencyConverter.Convert(amount, GetCurrencyName(from), GetCurrencyName(to));
            Console.WriteLine("{0} {1} = {2} {3}", amount, from.ToUpper(), result, to.ToUpper());

            Console.ReadLine();
        }

        static Currencies GetCurrencyName(string name)
        {
            return (Currencies)Enum.Parse(typeof(Currencies), name.ToUpper());
        }
    }
}
