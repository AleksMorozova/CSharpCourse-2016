using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4MyListExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> countries = new MyList<string>();
            countries.Add("Ukraine");
            countries.Add("Poland");
            countries.Add("Spain");
            countries.Add("Mexico");

            string [] result = countries.GetArray<string>();
            for (int i = 0; i <result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }

    
}
