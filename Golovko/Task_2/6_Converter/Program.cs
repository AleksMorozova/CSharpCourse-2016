using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(0.038, 0.034, 2.52);
            Console.WriteLine("{0} => {1} = {2:f4}", Symbol.UAH, Symbol.EUR, converter.Convert(100, Symbol.UAH, Symbol.EUR));
            Console.WriteLine("{0} => {1} = {2:f4}", Symbol.UAH, Symbol.RUB, converter.Convert(100, Symbol.UAH, Symbol.RUB));
            Console.WriteLine("{0} => {1} = {2:f4}", Symbol.USD, Symbol.UAH, converter.Convert(100, Symbol.USD, Symbol.UAH));
            Console.WriteLine("{0} => {1} = {2:f4}", Symbol.EUR, Symbol.USD, converter.Convert(100, Symbol.EUR, Symbol.USD));
            Console.ReadKey();
        }
    }
}
