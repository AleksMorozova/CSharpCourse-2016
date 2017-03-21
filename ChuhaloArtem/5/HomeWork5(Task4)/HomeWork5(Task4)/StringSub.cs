using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task4_
{
    static class StringSub
    {
        public static string MySubstring(this string substring, int sindex, int charCount)
        {
            string resultstring = string.Empty;
            if (sindex < 0 || sindex >= substring.Length)
            {
                Console.WriteLine("Invalid startIndex.");
            }
            else
            {
                if (sindex + charCount > substring.Length)
                {
                    Console.WriteLine("Invalid charCount.");
                }
                else
                {
                    for (int i = sindex; i < sindex + charCount; i++)
                    {
                        resultstring = resultstring + substring[i];
                    }
                }
            }
            return resultstring;
        }

        public static int MyIndexOf(this string substring, string offstring)
        {
            int result = 0;

            for (int i = 0; i < substring.Length; i++)
            {
                if ((substring.Length - i) < offstring.Length)
                {
                    break;
                }
                if (substring.MySubstring(i, offstring.Length).Equals(offstring))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static string MyReplace(this string substring, string oldValue, string newValue)
        {
            int index = substring.IndexOf(oldValue);
            return substring.MySubstring(0, index) + newValue;
        }
    }
}
