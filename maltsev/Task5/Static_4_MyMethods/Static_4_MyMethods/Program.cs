using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_4_MyMethods
{
    class String
    {
        static public string Substring(int a, int b)
        {
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hollywood!";
            Console.WriteLine(s.Substring(1, 5));//ollyw
            Console.WriteLine(s.IndexOf("llyw"));//2
            Console.WriteLine(s.Replace("wood" , "steel"));//Hollysteel!
            Console.ReadKey();
            
            
        }
    }
}
