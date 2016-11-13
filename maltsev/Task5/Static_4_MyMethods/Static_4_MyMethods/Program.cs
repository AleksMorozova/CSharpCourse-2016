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
        static public string Replace(string _str, string old, string news)
        {
            string changed_str = _str;
            string temp_str = _str;
            while (true)
            {
                int index = IndexOf(changed_str, old);

                if (index == -1)
                {
                    return changed_str;
                }
                temp_str = changed_str;
                changed_str = "";

                for (int i = 0; i < index; i++)
                {
                    changed_str += temp_str[i];
                }
                for (int i = 0; i < news.Length; i++)
                {
                    changed_str += news[i];
                }
                for (int i = index + old.Length; i < temp_str.Length; i++)
                {
                    changed_str += temp_str[i];
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hollywoodrewood!";//
            Console.WriteLine(s.Substring(1, 5));//ollyw
            Console.WriteLine(s.IndexOf("llyw"));//2
            Console.WriteLine(s.Replace("wood" , "steel"));//Hollysteelresteel!
            Console.WriteLine();

            Console.WriteLine(MyString.Substring(s, 1, 5));//ollyw
            Console.WriteLine(MyString.IndexOf(s, "llyw"));//2
            Console.WriteLine(MyString.Replace(s,"wood", "steel"));//Hollysteelresteel!
            Console.ReadKey();
            
            
        }
    }
}
