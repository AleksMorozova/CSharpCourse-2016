using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_Task1_
{
    delegate double AveragaDelegate(int a, int b, int c);

    class Program
    {
        static void Main(string[] args)
        {
            AveragaDelegate avr = new AveragaDelegate(Average.GetAvr);

            Console.WriteLine("Average: {0}", avr(3, 4, 5));
            Console.ReadKey();
        }
    }
}
