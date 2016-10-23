using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6CurrencyConverter
{
    class Converter
    {
        double usd;
        double eur;
        double rub;
        double resultOfConvertation;


        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            resultOfConvertation = 0;
        }

        public void ShowResult(int initialCurrency, int demandedCurrency, double amount)
        {
            Console.WriteLine("{0} {1} это {2} {3}", amount, ToNameInitialCurrency(initialCurrency),
                resultOfConvertation, ToNameDemandedCurrency(demandedCurrency));
        
        }

        public string ToNameInitialCurrency(int initialCurrency)
        {
            string nameOfInitialCurrency;
            switch (initialCurrency)
            { 
                case 1:
                    nameOfInitialCurrency = "гривен";
                    break;
                case 2:
                    nameOfInitialCurrency = "долларов";
                    break;
                case 3:                   
                    nameOfInitialCurrency =  "евро";
                    break;
                case 4:
                    nameOfInitialCurrency = "рублей";
                    break;
                default:
                    Console.WriteLine("Неправильно введена валюта!");
                    nameOfInitialCurrency = null;
                    break;
            }
            return nameOfInitialCurrency;
        }

        public string ToNameDemandedCurrency(int demandedCurrency)
        {
            string nameOfDemandedCurrency;
            switch (demandedCurrency)
            {
                case 1:
                    nameOfDemandedCurrency = "гривен";
                    break;
                case 2:
                    nameOfDemandedCurrency = "долларов";
                    break;
                case 3:
                    nameOfDemandedCurrency = "евро";
                    break;
                case 4:
                    nameOfDemandedCurrency = "рублей";
                    break;
                default:
                    Console.WriteLine("Неправильно введена валюта!");
                    nameOfDemandedCurrency = null;
                    break;
            }
            return nameOfDemandedCurrency;
        
        }

        public void Convert(int initialCurrency, int demandedCurrency, double amount)
        {
            if (initialCurrency == 1)
            {
                ConvertFromUAH(demandedCurrency, amount);
            }
            else
            {
                ConvertToUAH(initialCurrency, amount);
            }     
        }

        void ConvertFromUAH(int demandedCurrency, double amount)
        {
            switch (demandedCurrency)
            {
                case 2:
                    resultOfConvertation = amount * usd;                   
                    break;
                case 3:
                    resultOfConvertation = amount * eur;
                    break;
                case 4:
                    resultOfConvertation = amount * rub;
                    break;
                default:
                    Console.WriteLine("Неправильно введена валюта!!!");
                    break;
            }      
        }

        void ConvertToUAH(int initialCurrency, double amount)
        {
            switch (initialCurrency)
            {
                case 2:
                    resultOfConvertation = amount / usd;
                    break;
                case 3:
                    resultOfConvertation = amount / eur;
                    break;
                case 4:
                    resultOfConvertation = amount / rub;
                    break;
                default:
                    Console.WriteLine("Неправильно введена валюта!!!");
                    break;
            }
        }       

    }
}
