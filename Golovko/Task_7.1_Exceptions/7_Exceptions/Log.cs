using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Exceptions
{
    static class Log
    {
        public static void Write(string text)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("{0} --> {1}", currentDate.ToString(), text);
        }
    }
}
