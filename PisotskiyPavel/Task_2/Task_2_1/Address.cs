using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public Address()
        {

        }

        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public override string ToString()
        {
            return string.Format("Индекс: {1}{0}Страна: {2}{0}Город: {3}{0}Улица: {4}{0}Дом: {5}{0}Квартира: {6}", Environment.NewLine,
                                    Index, Country, City, Street, House, Apartment);
        }
    }
}
