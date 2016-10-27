using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_4
{
    static class StringExtensions
    {
        public static string Substring(this string value, int startIndex, int lenght)
        {
            string result = string.Empty;

            for (int i = startIndex; i < startIndex + lenght; i++)
            {
                result += value[i];
            }

            return result;
        }

        public static int IndexOf(this string str, string value)
        {
            int index = -1;

            if (value.Equals(string.Empty))
            {
                return 0;
            }

            for (int i = 0; i < str.Length - value.Length; i++)
            {
                string substring = Substring(str, i, value.Length);
                if (substring.Contains(value))
                {
                    index = i;
                    break;
                }
                    
            }

            return index;
        }

        public static string Replace(this string value, string oldValue, string newValue)
        {
            if (oldValue.Equals(string.Empty))
                return value;

            for (int i = 0; i < value.Length - oldValue.Length + 1; i++)
            {
                string substring = Substring(value, i, oldValue.Length);

                if (substring.Contains(oldValue))
                {
                    string start = value.Substring(0, i);
                    string end = value.Substring((oldValue.Length + i), value.Length - start.Length - oldValue.Length);
                    value = start + newValue + end;
                    if(newValue.Length > oldValue.Length)
                    {
                        i += newValue.Length - oldValue.Length;
                    }
                    else if(newValue.Length < oldValue.Length)
                    {
                        i -= oldValue.Length - newValue.Length;
                    }
                }

            }

            return value;
        }
    }
}
