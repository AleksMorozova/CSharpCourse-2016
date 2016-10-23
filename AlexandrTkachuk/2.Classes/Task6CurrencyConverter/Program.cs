using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int demandedCurrency;
            Converter converter = new Converter(0.039, 0.035, 2.436);
            Console.Write("Введите сумму: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите в какой валюте была введена сумма");
            Console.Write("(1 - гривны, 2 - доллары, 3 - евро, 4 - рубли): ");
            int initialCurrency = Convert.ToInt32(Console.ReadLine());
            if (initialCurrency == 1)
            {
                Console.Write("Укажите в какую валюту требуется конвертация: ");
                Console.Write("(1 - гривны, 2 - доллары, 3 - евро, 4 - рубли): ");
                demandedCurrency = Convert.ToInt32(Console.ReadLine());
            }
            else 
            {
                demandedCurrency = 1;
            }
            converter.Convert(initialCurrency, demandedCurrency, amount);
            converter.ShowResult(initialCurrency, demandedCurrency, amount);
         }


    }
}
