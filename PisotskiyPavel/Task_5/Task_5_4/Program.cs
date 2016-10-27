using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "H_e_l_l_o W_o_r_l_d!!!";
            Console.WriteLine("Слово: {0}{1}", str, Environment.NewLine);
            Console.WriteLine("Индекс знака {0}: {1}", "'W'", StringExtensions.IndexOf(str, "W"));
            Console.WriteLine(StringExtensions.Replace(str, "_", "___"));
            Console.WriteLine(StringExtensions.Replace(str, "_", ""));
            Console.WriteLine(StringExtensions.Substring(str, str.Length - 12, 9));

            Console.ReadLine();
        }
    }
}
