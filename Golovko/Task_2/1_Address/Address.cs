using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Address
{
    class Address
    {
        private uint index;
        private string country;
        private string city;
        private string street;
        private uint house;
        private uint apartment;
        public uint Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public uint House
        {
            get { return house; }
            set { house = value; }
        }
        public uint Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
        public void PrintAddressInfo()
        {
            Console.WriteLine("Index: {0}\nCountry: {1}\nCity: {2}\nStreet: {3}\nHouse: {4}\nApartment: {5}", index, country, city, street, house, apartment);
        }
    }
}
