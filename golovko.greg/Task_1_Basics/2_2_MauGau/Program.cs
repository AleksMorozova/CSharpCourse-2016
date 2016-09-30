using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_MauGau
{
    class Program
    {
        static void Main(string[] args)
        {
            IAct act = new Act();
            Console.WriteLine("Enter the command, please (Gau/Mau):");
            Console.Write("- ");
            Console.WriteLine("- {0}", act.MakeAct(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
