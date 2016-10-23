using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Adress
{
    class Adress
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;
       

        public int Index
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
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public Adress(int index, string country, string city, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        
        }

        public void ShowAdress()
        {
            Console.WriteLine("Adress:\nindex: {0}\ncountry: {1}\ncity: {2}\nstreet: {3}\nhouse: {4}\napartment: {5}",
            index, country, city, street, house, apartment);      
        }
    }
}
