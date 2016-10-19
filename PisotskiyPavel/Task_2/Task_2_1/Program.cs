using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address()
            {
                Index = 49044,
                Country = "Украина",
                City = "Днепр",
                Street = "ул. Шевченко",
                House = 14,
                Apartment = 202
            };

            Console.WriteLine(address.ToString());

            Console.ReadLine();
        }
    }
}
