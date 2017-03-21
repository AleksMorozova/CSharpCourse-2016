using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Артём Чухало";

            Console.WriteLine(str.MySubstring(sindex: 0, charCount: 3));
            Console.WriteLine(str.MyIndexOf(offstring: "e"));
            Console.WriteLine(str.Replace(oldValue: "Чухало", newValue: "Хабиб"));
            Console.ReadKey();
        }
    }
}
