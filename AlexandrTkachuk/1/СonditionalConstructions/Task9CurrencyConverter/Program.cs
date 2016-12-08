using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму : ");
            double amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите валюту, в которой вы вводите сумму. Доллары - 1, Евро - 2, Гривны - 3: ");
            int currency = Convert.ToInt32(Console.ReadLine());
            CurrencyConverter(currency, amount);
        }

        static void CurrencyConverter(int currency, double amount)
        {
            switch (currency)
            {
                case 1:
                    Console.WriteLine(amount + " долларов = " + amount * 0.89 + " евро = " + amount * 25.83 + " гривен.");
                    break;
                case 2:
                    Console.WriteLine(amount + " евро = " + amount * 1.12 + " долларов = " + amount * 28.98 + " гривен.");
                    break;
                case 3:
                    Console.WriteLine(amount + " гривен = " + amount * 0.0387 + " долларов = " + amount * 0.0345 + " евро.");
                    break;
                default:
                    Console.WriteLine("Неправильно введена валюта");
                    break;
            }
        }
    }
}
