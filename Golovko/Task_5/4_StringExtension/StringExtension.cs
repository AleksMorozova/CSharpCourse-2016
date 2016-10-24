using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_StringExtension
{
    static class StringExtension
    {
        public static string Substring(this string substring, int startIndex, int countChars)
        {
            string result = string.Empty;
            if (startIndex < 0 || startIndex >= substring.Length)
            {
                Console.WriteLine("Invalid startIndex argument. Must be between 0 and length of the string");
            }
            else
            {
                if (startIndex + countChars > substring.Length)
                {
                    Console.WriteLine("Invalid countChars argument.");
                }
                else
                {
                    for (int i = startIndex; i < startIndex + countChars; i++)
                    {
                        try
                        {
                            result += substring[i];
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                            result = string.Empty;
                        }
                    }
                }
            }            
            return result;
        }
        public static int IndexOf(this string substring, string stringValue)
        {
            int result = 0;
            if (substring.Length < stringValue.Length)
            {
                Console.WriteLine("Substring length must be greater than string value");
            }
            else
            {
                for (int i = 0; i < substring.Length; i++)
                {
                    if (substring.Length - i < stringValue.Length)
                    {
                        break;
                    }
                    if (substring.Substring(startIndex: i, countChars: stringValue.Length).Equals(stringValue))
                    {
                        result = i;
                        break;
                    }
                }
            }
            return result;
        }
        public static string Replace(this string substring, string oldValue, string replaceValue)
        {
            int index = substring.IndexOf(stringValue: oldValue);
            return 
                substring.Substring(startIndex: 0, countChars: index) + 
                replaceValue +
                substring.Substring(startIndex: index + oldValue.Length, countChars: substring.Length - index - oldValue.Length);
        }
    }
}
