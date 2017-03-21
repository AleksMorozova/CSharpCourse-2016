using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Classes_
{
    class Converter
    {
        double grn=0;
        double cdoll;
        double ceuro;
        double crub;
        double doll=0;
        double euro=0;
        double rub=0;

        public Converter(double cdoll, double ceuro, double crub)
        {
            this.cdoll = cdoll;
            this.ceuro = ceuro;
            this.crub = crub;
        }

        public double GetGrn
        {
            get { return grn;}
            set { grn=value;}
        }
        public double GetDoll
        {
            get { return doll; }
            set { doll = value; }
        }
        public double GetEuro
        {
            get { return euro; }
            set { euro = value; }
        }
        public double GetRub
        {
            get { return rub; }
            set { rub = value; }
        }        
        
        public void Print()
        {
            string str;
            
            Console.Write("\nSwitch the money kind(doll, grn, rub, euro): ");
            str = Console.ReadLine();

            switch(str)
            {
                case "doll":
                    {
                        Console.Write("\nSet amount: ");
                        GetDoll = Convert.ToDouble(Console.ReadLine());
                        doll = GetDoll;
                        grn = doll * cdoll;
                        euro = grn / ceuro;
                        rub = grn * crub;
                        break;
                    }
                case "grn":
                    {
                        Console.Write("\nSet amount: ");
                        GetGrn = Convert.ToDouble(Console.ReadLine());
                        grn = GetGrn;
                        doll=grn/cdoll;
                        euro=grn/ceuro;
                        rub = grn*crub;
                        break;
                    }
                case "rub":
                    {
                        Console.Write("\nSet amount: ");
                        GetRub = Convert.ToDouble(Console.ReadLine());
                        rub = GetRub;
                        grn = rub / crub;
                        doll = grn / cdoll;
                        euro = grn / ceuro;
                        break;
                    }
                case"euro":
                    {
                        Console.Write("\nSet amount: ");
                        GetEuro = Convert.ToDouble(Console.ReadLine());
                        euro = GetEuro;
                        grn = euro * ceuro;
                        doll = grn / cdoll;
                        rub = grn * crub;
                        break;
                    }
                default:
                        {break;}
            }
            Console.Write("\nGRN -{0}, DOLLAR - {1}\nGRN - {0}, EURO - {2}\nGRN - {0}, RUB - {3}", grn, doll, euro, rub);
        }
    }
}
