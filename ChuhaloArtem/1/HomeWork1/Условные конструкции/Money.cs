using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Money
    {
        public void Function()
        {
            double courseDtoE=0.5;
            double courseDtoG=5;
            double courseEtoG=10;

            Console.Write("\nChoose money type (grn, dollar, euro): ");
            string kind = Console.ReadLine();
            Console.Write("How much: ");
            double sum = Convert.ToInt32(Console.ReadLine());

            switch(kind)
            {
                case "grn":
                    double sumE = sum / courseEtoG;
                    double sumD = sum / courseDtoG;
                    Console.WriteLine("\nGRN - {0}, DOLLAR - {1}\nGRN - {0}, EURO - {2}", sum, sumD, sumE);
                    break;

                case "dollar":
                    sumE = sum * courseDtoE;
                    double sumG = sum*courseDtoG ;
                    Console.WriteLine("\nDOLLAR - {0}, GRN - {1}\nDOLLAR - {0}, EURO - {2}", sum, sumG, sumE);
                    break;

                case "euro":
                    sumD = sum / courseDtoE;
                    sumG = sum * courseEtoG;
                    Console.WriteLine("\nEURO - {0}, GRN - {1}\nEURO - {0}, DOLLAR - {2}", sum, sumG, sumD);
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please select proposed item");
                    break;
            }
        }
    }
}
