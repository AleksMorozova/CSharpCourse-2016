using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Animals
    {
        public void Pets()
        {
            string kind;
            Console.Write("\nWhat say your pet? мяу/гав: ");
            kind = Console.ReadLine();
            if (kind == "мяу")
                Console.WriteLine("\nПокорми кота."); 
            else
                if (kind == "гав")                
                    Console.WriteLine("\nПогуляй с собакой");
                else                
                    if (kind != "мяу" || kind != "гав")
                        Console.WriteLine("\nInvalid selection. Please select proposed item");
        }
    }
}
