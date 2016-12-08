using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1AverageValue
{
    delegate double AverageDel(int num1, int num2, int num3);
    class Program
    {
        
        static void Main(string[] args)
        {
            AverageDel averageDel = delegate(int num1, int num2, int num3)
            {
                return (num1 + num2 + num3) / 3;
            };

            Console.WriteLine("Среднее значение: " + averageDel(12, 8, 4));            
        }
       
    }
}
