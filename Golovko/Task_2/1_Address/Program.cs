using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 624019;
            address.Country = "Ukraine";
            address.City = "Dnepr";
            address.Street = "K. Marks street";
            address.House = 54;
            address.Apartment = 19;
            address.PrintAddressInfo();
            Console.ReadKey();
        }
    }
}
