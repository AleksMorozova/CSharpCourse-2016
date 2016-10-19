using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(32566, "Писоцкий Павел", "Google");
            invoice.Article = "Регистрация доменного имени: .ua";
            invoice.Quantity = 2;
            invoice.Price = 1000;
            Console.WriteLine("Счет №{0}", invoice.Account);
            Console.WriteLine("Заказчик: {0}", invoice.Customer);
            Console.WriteLine("Поставщик: {0}", invoice.Provider);
            Console.WriteLine("{0} - {1}шт.", invoice.Article, invoice.Quantity);
            Console.WriteLine("Цена (без НДС): {0}",invoice.CostWithoutNds());
            Console.WriteLine("Цена (с НДС): {0}", invoice.CostWithNds());

            Console.ReadLine();
        }
    }
}
