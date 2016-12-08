using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(2, "Barcelona");
            cities.Add(5, "London");
            cities.Add(7, "Paris");

            foreach (KeyValuePair<int, string> pair in cities)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
