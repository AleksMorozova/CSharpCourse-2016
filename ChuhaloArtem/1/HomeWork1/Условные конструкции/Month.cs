using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Month
    {
        public void Time()
        {            
            Console.Write("\nEnter month number (1-12): ");
            int number = int.Parse(Console.ReadLine());

            if (number == 1 || number == 2 || number == 12)
                Console.WriteLine("Зима!");
            if (number == 3 || number == 4 || number == 5)
                Console.WriteLine("Весна!");
            if (number == 6 || number == 7 || number == 8)
                Console.WriteLine("Лето!");
            if (number == 9 || number == 10 || number == 11)
                Console.WriteLine("Осень!");
            if (number < 1 && number > 12)
                Console.WriteLine("\nInvalid selection. Please select proposed item");
        }
    }
}
