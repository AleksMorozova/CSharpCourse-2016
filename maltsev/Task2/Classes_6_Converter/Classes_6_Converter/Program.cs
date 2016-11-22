using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_6_Converter
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        
        public void ConvertFromHRN(double amount)
        {
            Console.WriteLine("{0} HRN", amount);
            Console.WriteLine("{0} USD", amount*usd);
            Console.WriteLine("{0} EUR", amount*eur);
            Console.WriteLine("{0} RUB", amount*rub);
            Console.WriteLine("");
        }
        public void ConvertFromUSD(double amount)
        {
            Console.WriteLine("{0:#.##} USD", amount);
            Console.WriteLine("{0:#.##} HRN", amount / usd);
            Console.WriteLine("");
        }
        public void ConvertFromEUR(double amount)
        {
            Console.WriteLine("{0:#.##} EUR", amount);
            Console.WriteLine("{0:#.##} HRN", amount / eur);
            Console.WriteLine("");
        }
        public void ConvertFromRUB(double amount)
        {
            Console.WriteLine("{0:#.##} RUB", amount);
            Console.WriteLine("{0:#.##} HRN", amount / rub);
            Console.WriteLine("");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter1 = new Converter(0.04, 0.03, 2.4);
            converter1.ConvertFromHRN(178333.0);
            converter1.ConvertFromUSD(1000.0);
            converter1.ConvertFromEUR(1000.0);
            converter1.ConvertFromRUB(1000.0);
            Console.ReadKey();
        }
    }
}
