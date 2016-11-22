using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DelegatesArray
{
    static class Log
    {
        public static void Write(string text, params object[] args)
        {
            Console.WriteLine(text, args);
        }
    }
}
