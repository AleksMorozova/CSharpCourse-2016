using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_4_MyMethods
{
    static class MyString
    {
        static public string Substring(string _str, int a, int b)
        {
            string temp = "";
            for (int i = a; i < a+b; i++)
            {
                temp += _str[i];
            }
            return temp;
        }
        static public int IndexOf(string _str, string part)
        {
            if(part == String.Empty)
            {
                return -1;
            }

            for ( int i = 0; i < _str.Length - part.Length; i++)
            {
                string sub = Substring(_str, i, part.Length);
                if (sub == part)
                {
                    return i;
                }
            }

            return -1;
        }
        static public string Replace(string _str, string first, string second)
        {
            string temp = "";
            int index = IndexOf(_str, first);

            if (index == -1)
            {
                return _str;
            }

            for (int i = 0; i < index; i++)
            {
                temp += _str[i];
            }
            for (int i = 0; i < second.Length; i++)
            {
                temp += second[i];
            }
            for (int i = index + first.Length; i < _str.Length; i++)
            {
                temp += _str[i];
            }
            return temp;

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
            Console.WriteLine();
            Console.WriteLine(MyString.Substring(s, 1, 5));//ollyw
            Console.WriteLine(MyString.IndexOf(s, "llyw"));//2
            Console.WriteLine(MyString.Replace(s,"wood", "steel"));//Hollysteel!
            Console.ReadKey();
            
            
        }
    }
}
