using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Biger
    {
        public void Match()
        {
            Console.WriteLine("\nEnter first item: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second item: ");
            int second = int.Parse(Console.ReadLine());        

            if (first > second)
                Console.WriteLine("\n"+first);
            else
                Console.WriteLine("\n"+second);            
        }
    }
}
