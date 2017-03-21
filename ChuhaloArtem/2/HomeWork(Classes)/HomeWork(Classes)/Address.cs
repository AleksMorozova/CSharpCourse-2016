using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get {return index;}
            set {index=value;}
        }
        public string Country
        {
            get {return country; }
            set {country=value;}
        }
        public string City
        {
            get {return city; }
            set {city=value;}
        }
        public string Street
        {
            get {return street; }
            set {street=value;}
        }
        public int House
        {
            get {return house;}
            set {house=value;}
        }
        public int Apartment
        {
            get {return apartment; }
            set {apartment=value;}
        }

        public void PrintAddress()
        {
            Index = 4900;
            Country = "Ukraine";
            City = "Dnepr";
            Street = "Main Street";
            House = 13;
            Apartment = 22;

            Console.WriteLine("\nIndex:" + Index + ", Country:" + Country + ", City:" + City + ", Street:" + Street + ", House:" + House + ", Apartment:" + Apartment);
        }
    }
}
