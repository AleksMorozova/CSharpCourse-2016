using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1_Address
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;
        public string Index
        {
            set { index = value; }
            get { return index; }
        }
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Street
        {
            set { street = value; }
            get { return street; }
        }
        public string House
        {
            set { house = value; }
            get { return house; }
        }
        public string Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address addressFirst = new Address();
            addressFirst.Index = "49000";
            addressFirst.Country = "Ukraine";
            addressFirst.City = "Dnepr";
            addressFirst.Street = "K.Marksa";
            addressFirst.House = "59";
            addressFirst.Apartment = "333";
            Console.WriteLine(addressFirst.Index);
            Console.WriteLine(addressFirst.Country);
            Console.WriteLine(addressFirst.City);
            Console.WriteLine(addressFirst.Street);
            Console.WriteLine(addressFirst.House);
            Console.WriteLine(addressFirst.Apartment);
            Console.ReadKey();

        }
    }
}
